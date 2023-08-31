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
                Id = t.Id,
                Name = t.Name
            }).ToList();
        }
    }
}
