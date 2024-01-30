using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("tbl_marks")]
    public class Marks
    {
        [Key]
        public Guid MarksId { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(20)]
        public string Exam {  get; set; }
        public int? TotalMarks {  get; set; } 
        public int StudentId {  get; set; }
        //navigation property for
        [ForeignKey("StudentId")]
        public Student Student { get; set; }    
    }
}
