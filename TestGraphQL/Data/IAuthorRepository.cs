using TestGraphQL.Database;

namespace TestGraphQL.Data
{
    public interface IAuthorRepository
    {
        Task<Author?> GetAuthorById(int id);
        IEnumerable<Author> GetAuthors();
    }
}