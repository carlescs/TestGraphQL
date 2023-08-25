using TestGraphQL.Database;

namespace TestGraphQL.Data
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();
    }
}