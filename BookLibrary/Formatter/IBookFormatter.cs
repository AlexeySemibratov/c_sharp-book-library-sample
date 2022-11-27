using BookLibrary.Data.Entity;

namespace BookLibrary.Formatter
{
    public interface IBookFormatter
    {
        string Format(Book book);
    }
}
