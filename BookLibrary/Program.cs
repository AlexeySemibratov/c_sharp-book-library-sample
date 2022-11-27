using BookLibrary.Data;
using BookLibrary.Data.TestUseCases;
using BookLibrary.Formatter;
using BookLibrary.TestUseCases;

IBookRepository bookRepository = new FakeBookRepository();

IBookFormatter commonBookFormatter = new CommonBookFormatter();
IBookFormatter releaseYearFirstFormatter = new ReleaseYearFirstBookFormatter();

Console.WriteLine("Вся библиотека:");
new PrintAllLibraryUseCase(bookRepository, commonBookFormatter).Run();
SkipLine();

Console.WriteLine("Библиотека с сортировкой по дате выпуска:");
new PrintBooksSortedByReleaseYearUseCase(bookRepository, releaseYearFirstFormatter).Run();
SkipLine();

Console.WriteLine("Все книги Пушкина из библиотеки:");
new PrintAllPushkinsBookUseCase(bookRepository, commonBookFormatter).Run();
SkipLine();

void SkipLine()
{
    Console.WriteLine();
}