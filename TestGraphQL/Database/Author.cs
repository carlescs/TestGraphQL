using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestGraphQL.Database
{
    [Table("Author")]
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(512), Required]
        public string Name { get; set; } = null!;
    }
}