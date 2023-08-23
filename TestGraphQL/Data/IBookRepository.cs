using TestGraphQL.Model;

namespace TestGraphQL.Data
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
    }
}