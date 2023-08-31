using TestGraphQL.Data;
using TestGraphQL.Model;

namespace TestGraphQL.Mutations
{
    [ExtendObjectType<Mutation>]
    public class BookMutations
    {
        public async Task<Book> AddBookAsync(BookToAdd book, [Service] IBookRepository bookRepository)
        {
            var dbAuthor =await bookRepository.AddauthorIfNotExists(book.Author);
            if(dbAuthor == null) throw new Exception("Author is null");
            var addedBook=await bookRepository.AddBookAsync(new Database.Book { Title=book.Title, Author=dbAuthor});
            return new Book
            {
                Id=addedBook.Id,
                Title=addedBook.Title
            };
        }
    }
}
