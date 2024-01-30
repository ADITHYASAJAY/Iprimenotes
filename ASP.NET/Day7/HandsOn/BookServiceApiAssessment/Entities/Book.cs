using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookServiceApiAssessment.Entities
{
    [Table("tbl_books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string? BookName { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Price { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string? Author { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string? Lang { get; set; }

        public int ReleaseDate { get; set; }
    }
}
