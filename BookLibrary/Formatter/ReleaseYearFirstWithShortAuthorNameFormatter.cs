using BookLibrary.Data.Entity;

namespace BookLibrary.Formatter
{
    public class ReleaseYearFirstBookFormatter : IBookFormatter
    {
        private const string FORMAT_TEXT = "({0} год) -  {1} ({2} {3})";
        public string Format(Book book)
        {
            Author author = book.Author;
            return string.Format(
                FORMAT_TEXT,
                book.ReleaseYear,
                book.Name,
                author.LastName,
                author.FirstName);
        }
    }
}
