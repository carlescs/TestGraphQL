using TestGraphQL.Model;

namespace TestGraphQL.Data
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        Book? GetBookByTitle(string title);
        List<Book> GetBooks();
    }
}