namespace BookLibrary.Data.Entity
{
    public record Book(
        Author Author,
        string Name,
        int ReleaseYear
        );
}
