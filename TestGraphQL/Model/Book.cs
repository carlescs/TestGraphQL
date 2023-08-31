using System.ComponentModel.DataAnnotations;
using TestGraphQL.Data;

namespace TestGraphQL.Model
{
    public class Book
    {
        [ID] public int Id { get; set; }

        [MaxLength(256), Required]
        public string Title { get; set; } = null!;
        public async Task<Author?> GetAuthorAsync([Service] IAuthorRepository authorRepository)
        {
            var author = await authorRepository.GetAuthorById(this.Id);
            if(author == null)
                return null;
            return new Author
            {
                Id = author.Id,
                Name = author.Name
            };
        }
    }

    public class BookToAdd
    {
        [Required, MaxLength(256)]
        public string Title { get; set; }=null!;

        [Required]
        public AuthorToAdd Author { get; set; } = null!;
    }
}
