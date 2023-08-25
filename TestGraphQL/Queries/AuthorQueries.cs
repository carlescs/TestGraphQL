using TestGraphQL.Data;

namespace TestGraphQL.Queries
{
    [ExtendObjectType<Query>]
    public class AuthorQueries
    {
        public List<Model.Author> GetAuthors([Service] IAuthorRepository authorRepository)
        {
            var authors = authorRepository.GetAuthors();
            return authors.Select(t => new Model.Author
            {
                Name = t.Name,
                Books=t.Books.Select(b=>new Model.Book
                {
                    Title=b.Title
                }).ToList()
            }).ToList();
        }
    }
}
