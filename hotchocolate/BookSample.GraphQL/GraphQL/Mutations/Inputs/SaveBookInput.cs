namespace BookSample.GraphQL.GraphQL.Mutations.Inputs;

public abstract class SaveBookInput
{
    public required string Title { get; set; }

    public required string Description { get; set; }

    public required string ISBN { get; set; }

    [ID]
    public required long AuthorId { get; set; }

    [ID]
    public required long PublisherId { get; set; }

    [ID]
    public required string GenreId { get; set; }

    public required DateOnly PublishedAt { get; set; }
}
