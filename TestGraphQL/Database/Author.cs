using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestGraphQL.Database
{
    [Table("Author")]
    [Index(nameof(Name), Name = "UniqueName", IsUnique = true)]
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(512), Required]
        public string Name { get; set; } = null!;

        public ICollection<Book> Books { get; set; } = null!;
    }
}