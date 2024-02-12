using BookSample.ReviewAPIClient.Models;
using BookSample.ReviewAPIClient;

namespace BookSample.GraphQL.GraphQL.DataLoader;

public class RatingBatchDataloader(ReviewsClient reviewsClient, ILogger<RatingBatchDataloader> logger, IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : BatchDataLoader<long, Rating>(batchScheduler, options)
{
    private static readonly Dictionary<long, Rating> s_emptyRatingList = [];

    protected override async Task<IReadOnlyDictionary<long, Rating>> LoadBatchAsync(IReadOnlyList<long> keys, CancellationToken cancellationToken)
    {
        logger.LogDebug("Making HTTP call to ReviewAPI to get rating for {keys}.", keys);

        var result = await reviewsClient.Api
            .Ratings
            .GetAsync(x => x.QueryParameters.BookIds = keys.ToStrings(), cancellationToken);

        return result?
            .Where(x => x.BookId.HasValue)
            .ToDictionary(x => x.BookId!.Value)
            ?? s_emptyRatingList;
    }
}