using System.ComponentModel.DataAnnotations;
using TestGraphQL.Data;

namespace TestGraphQL.Model
{
    public class Author
    {
        [ID] public int Id { get; set; }

        [MaxLength(512), Required]
        public string Name { get; set; } = null!;
        public List<Book>? GetBooks([Service] IBookRepository bookRepository)
        {
            return bookRepository.GetBooksByAuthorId(this.Id).Select(t=>new Book
            {
                Id = t.Id,
                Title = t.Title
            }).ToList();
        }
    }

    public class AuthorToAdd
    {
        [Required, MaxLength(512)]
        public string Name { get; set; } = null!;
    }
}