using Microsoft.EntityFrameworkCore;
using TestGraphQL.Database;

namespace TestGraphQL.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddBookAsync(Book book)
        {
            _dbContext.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        public List<Book> GetBooks()
        {
            return _dbContext.Books.Include(b => b.Author).ToList();
        }

        public async Task<Book?> GetBookByTitleAsync(string title)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(b => b.Title==title);
        }

        public async Task<Author?> AddauthorIfNotExists(Model.Author author)
        {
            if (author == null) return null;
            var dbAuthor=await _dbContext.Authors.FirstOrDefaultAsync(t=>t.Name==author.Name);
            if (dbAuthor == null)
            {
                dbAuthor=new Author { Name=author.Name};
                _dbContext.Add(dbAuthor);
                _dbContext.SaveChanges();
            }
            return dbAuthor;
        }
    }
}