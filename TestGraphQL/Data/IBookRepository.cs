using TestGraphQL.Database;

namespace TestGraphQL.Data
{
    public interface IBookRepository
    {
        Task<Author?> AddauthorIfNotExists(Model.AuthorToAdd author);
        Task<Book> AddBookAsync(Book book);
        Task<Book?> GetBookByTitleAsync(string title);
        IEnumerable<Book> GetBooks();
        IEnumerable<Book> GetBooksByAuthorId(int id);
    }
}