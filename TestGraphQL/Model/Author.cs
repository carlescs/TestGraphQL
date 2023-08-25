using System.ComponentModel.DataAnnotations;

namespace TestGraphQL.Model
{
    public class Author
    {
        [MaxLength(512), Required]
        public string Name { get; set; } = null!;
        public List<Book>? Books { get;  set; }
    }
}