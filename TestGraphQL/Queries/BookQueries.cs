using TestGraphQL.Data;
using TestGraphQL.Model;

namespace TestGraphQL.Queries
{
    [ExtendObjectType(typeof(Query))]
    public class BookQueries
    {
        public Book? GetBook(string title, [Service] IBookRepository bookRepository)
        {
            return bookRepository.GetBookByTitle(title);
        }

        public List<Book> GetBooks([Service] IBookRepository bookRepository)
        {
            var books = bookRepository.GetBooks();
            return books;
        }
    }
}
