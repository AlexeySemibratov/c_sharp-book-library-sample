using BookLibrary.Data.Entity;

namespace BookLibrary.Data
{
    public interface IBookRepository
    {
        List<Book> GetAll();

        void AddBook(Book book);
        void RemoveBook(string bookName);

        List<Book> GetBooksByAuthor(Author author);

        List<Book> GetBooksByReleaseYear(int year);

        List<Book> GetBooksByNameQuery(string query);

    }
}
