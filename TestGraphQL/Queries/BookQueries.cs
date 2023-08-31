using TestGraphQL.Data;
using TestGraphQL.Model;

namespace TestGraphQL.Queries
{
    [ExtendObjectType<Query>]
    public class BookQueries
    {
        public async Task<Book?> GetBookAsync(string title, [Service] IBookRepository bookRepository)
        {
            Database.Book? book = await bookRepository.GetBookByTitleAsync(title);
            if(book==null)
                return null;
            return new Book
            {
                Id = book!.Id,
                Title= book!.Title
            };
        }

        public List<Book> GetBooks([Service] IBookRepository bookRepository)
        {
            var books = bookRepository.GetBooks();
            return books.Select(t=>new Book
            {
                Id = t.Id,
                Title = t.Title
            }).ToList();
        }
    }
}
