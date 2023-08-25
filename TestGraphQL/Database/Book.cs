using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestGraphQL.Database
{
    [Table("Book")]
    [Index(nameof(Title),Name = "UniqueTitle", IsUnique = true)]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256),Required]
        public string Title { get; set; } = null!;
        public Author Author { get; set; } = null!;
    }
}
