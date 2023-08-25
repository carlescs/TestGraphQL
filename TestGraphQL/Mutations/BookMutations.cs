using TestGraphQL.Data;
using TestGraphQL.Model;

namespace TestGraphQL.Mutations
{
    [ExtendObjectType(typeof(Mutation))]
    public class BookMutations
    {
        public async Task<Book> AddBookAsync(Book book, [Service] IBookRepository bookRepository)
        {
            var dbAuthor =await bookRepository.AddauthorIfNotExists(book.Author);
            if(dbAuthor == null) throw new Exception("Author is null");
            await bookRepository.AddBookAsync(new Database.Book { Title=book.Title, Author=dbAuthor});
            return book;
        }
    }
}
