using BookLibrary.Data.Entity;

namespace BookLibrary.Data
{
    public class FakeBookRepository : IBookRepository
    {

        private List<Book> _bookList = new List<Book>() {
            new Book(
                Author: Authors.LevTolstoy,
                Name: "Война и Мир",
                ReleaseYear: 1867
                ),
            new Book(
                Author: Authors.LevTolstoy,
                Name: "Анна Каренина",
                ReleaseYear: 1875
                ),
            new Book(
                Author: Authors.LevTolstoy,
                Name: "Воскресенье",
                ReleaseYear: 1899
                ),
            new Book(
                Author: Authors.LevTolstoy,
                Name: "Воскресенье",
                ReleaseYear: 1899
                ),
            new Book(
                Author: Authors.AlexanderPushkin,
                Name: "Кавказский пленник",
                ReleaseYear: 1822
                ),
            new Book(
                Author: Authors.AlexanderPushkin,
                Name: "Евгений Онегин",
                ReleaseYear: 1825
                ),
            new Book(
                Author: Authors.AlexanderPushkin,
                Name: "Медный всадник",
                ReleaseYear: 1833
                ),
            new Book(
                Author: Authors.RayBradbury,
                Name: "Марсианские хроники",
                ReleaseYear: 1950
                ),
            new Book(
                Author: Authors.RayBradbury,
                Name: "451 градус по Фаренгейту",
                ReleaseYear: 1953
                ),
            new Book(
                Author: Authors.MaksimGorky,
                Name: "На дне",
                ReleaseYear: 1901
                ),
            new Book(
                Author: Authors.MaksimGorky,
                Name: "Старуха Изергиль",
                ReleaseYear: 1894
                ),
            new Book(
                Author: Authors.PauloCoelho,
                Name: "Алхимик",
                ReleaseYear: 1988
                ),
        };

        public void AddBook(Book book)
        {
            if (_bookList.Contains(book) == false)
            {
                _bookList.Add(book);
            }
            else
            {
                throw new ArgumentException(string.Format("В репозитории уже есть книга {0}", book));
            }
        }

        public void RemoveBook(string bookName)
        {
            if (_bookList.Any(book => book.Name == bookName))
            {
                Book book = _bookList.First(book => book.Name == bookName);
                _bookList.Remove(book);
            } 
            else
            {
                throw new ArgumentException(string.Format("В репозитории нет книги c названием {0}", bookName));
            }
        }

        public List<Book> GetAll()
        {
            return _bookList;
        }

        public List<Book> GetBooksByAuthor(Author author)
        {
            return _bookList.Where(book => book.Author == author).ToList();
        }

        public List<Book> GetBooksByNameQuery(string query)
        {
            return _bookList.Where(book => book.Name.Contains(query)).ToList();
        }

        public List<Book> GetBooksByReleaseYear(int year)
        {
            return _bookList.Where(book => book.ReleaseYear == year).ToList();
        }
    }
}
