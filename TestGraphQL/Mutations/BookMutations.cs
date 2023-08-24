using TestGraphQL.Data;
using TestGraphQL.Model;

namespace TestGraphQL.Mutations
{
    public class BookMutations
    {
        public Book AddBook(Book book, [Service] IBookRepository bookRepository)
        {
            bookRepository.AddBook(book);
            return book;
        }
    }
}
