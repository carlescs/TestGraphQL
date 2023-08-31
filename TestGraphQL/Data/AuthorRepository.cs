using Microsoft.EntityFrameworkCore;
using TestGraphQL.Database;

namespace TestGraphQL.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Author?> GetAuthorById(int id)
        {
            return await _dbContext.Authors.FirstOrDefaultAsync(t=>t.Id==id);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _dbContext.Authors.Include(t=>t.Books);
        }
    }
}