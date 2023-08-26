using System.ComponentModel.DataAnnotations;

namespace TestGraphQL.Model
{
    public class Author
    {
        [ID] public int Id { get; set; }

        [MaxLength(512), Required]
        public string Name { get; set; } = null!;
        public List<Book>? Books { get;  set; }
    }
}