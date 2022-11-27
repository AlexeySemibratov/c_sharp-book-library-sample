using BookLibrary.Data.Entity;
using BookLibrary.Formatter;

namespace BookLibrary.Data.TestUseCases
{
    public class PrintAllLibraryUseCase : ITestUseCase
    {

        private IBookRepository _bookRepository;
        private IBookFormatter _bookFormatter;
        public PrintAllLibraryUseCase(IBookRepository bookRepository, IBookFormatter bookFormatter)
        {
            _bookRepository = bookRepository;
            _bookFormatter = bookFormatter;
        }

        public void Run()
        {
            List<Book> books = _bookRepository.GetAll();
            books.ForEach(book => Console.WriteLine(_bookFormatter.Format(book)));
        }
    }
}
