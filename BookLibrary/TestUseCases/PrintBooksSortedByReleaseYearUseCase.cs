using BookLibrary.Data.Entity;
using BookLibrary.Formatter;

namespace BookLibrary.Data.TestUseCases
{
    public class PrintBooksSortedByReleaseYearUseCase
    {
        private IBookRepository _bookRepository;
        private IBookFormatter _bookFormatter;

        private Comparison<Book> _sortByReleaseYear = (x, y) => x.ReleaseYear.CompareTo(y.ReleaseYear);
        public PrintBooksSortedByReleaseYearUseCase(IBookRepository bookRepository, IBookFormatter bookFormatter)
        {
            _bookRepository = bookRepository;
            _bookFormatter = bookFormatter;
        }

        public void Run()
        {
            List<Book> books = _bookRepository.GetAll();
            books.Sort(_sortByReleaseYear);

            books.ForEach(book => Console.WriteLine(_bookFormatter.Format(book)));
        }
    }
}
