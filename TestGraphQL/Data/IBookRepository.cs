using TestGraphQL.Database;

namespace TestGraphQL.Data
{
    public interface IBookRepository
    {
        Task<Author?> AddauthorIfNotExists(Model.Author author);
        Task AddBookAsync(Book book);
        Task<Book?> GetBookByTitleAsync(string title);
        List<Book> GetBooks();
    }
}