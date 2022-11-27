using BookLibrary.Data.Entity;

namespace BookLibrary.Formatter
{
    public class CommonBookFormatter : IBookFormatter
    {

        private const string FORMAT_TEXT = "{0} {1} {2} - {3} ({4} год)";
        public string Format(Book book)
        {
            Author author = book.Author;
            return string.Format(
                FORMAT_TEXT,
                author.LastName,
                author.FirstName,
                author.MiddleName,
                book.Name,
                book.ReleaseYear,
                author);
        }
    }
}
