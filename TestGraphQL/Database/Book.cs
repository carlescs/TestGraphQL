using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestGraphQL.Database
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256),Required]
        public string Title { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
