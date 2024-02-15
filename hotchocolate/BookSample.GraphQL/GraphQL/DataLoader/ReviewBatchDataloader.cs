using BookSample.ReviewAPIClient;
using BookSample.ReviewAPIClient.Models;

namespace BookSample.GraphQL.GraphQL.DataLoader;

public class ReviewBatchDataloader(ReviewClient reviewsClient, IBatchScheduler batchScheduler, DataLoaderOptions? options = null) : BatchDataLoader<long, IEnumerable<Review>>(batchScheduler, options)
{
    private static readonly List<Review> s_emptyReviewList = [];

    internal int? TakeParameter { get; set; }

    protected override async Task<IReadOnlyDictionary<long, IEnumerable<Review>>> LoadBatchAsync(IReadOnlyList<long> keys, CancellationToken cancellationToken)
    {
        var result = await reviewsClient.Api
            .Reviews
            .GetAsync(config =>
            {
                config.QueryParameters.BookIds = keys.ToStrings();
                config.QueryParameters.Take = TakeParameter;
            }, cancellationToken)
            ?? s_emptyReviewList;
        return result
            .Where(x => x.BookId != default)
            .GroupBy(x => x.BookId!.Value)
            .ToDictionary(x => x.Key, x => x.AsEnumerable());
    }
}