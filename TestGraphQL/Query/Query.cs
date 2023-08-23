using TestGraphQL.Model;

namespace TestGraphQL.Query
{
    public class Query
    {
        public Book GetBook() => new Book
        {
            Title = "C# in Depth",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
    }
}
