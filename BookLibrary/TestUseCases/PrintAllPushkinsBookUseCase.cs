using BookLibrary.Data.Entity;
using BookLibrary.Data;
using BookLibrary.Data.TestUseCases;
using BookLibrary.Formatter;

namespace BookLibrary.TestUseCases
{
    public class PrintAllPushkinsBookUseCase : ITestUseCase
    {
        private IBookRepository _bookRepository;
        private IBookFormatter _bookFormatter;
        public PrintAllPushkinsBookUseCase(IBookRepository bookRepository, IBookFormatter bookFormatter)
        {
            _bookRepository = bookRepository;
            _bookFormatter = bookFormatter;
        }

        public void Run()
        {
            List<Book> books = _bookRepository.GetBooksByAuthor(Authors.AlexanderPushkin);
            books.ForEach(book => Console.WriteLine(_bookFormatter.Format(book)));
        }
    }
}
