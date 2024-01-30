using System.ComponentModel.DataAnnotations;
namespace AssignmentOnModelValidation.Models
{
    public class Movie
    {
        public Movie() 
        {
            this.Id = new Random().Next(1000, 9999);
        }
        public int Id { get;  }
        [Required(ErrorMessage ="Enter Movie Name")]
        public string MovieName { get; set; }
        
        [Required(ErrorMessage = "Enter Language")]
       
        public string Language {  get; set; }

        [Required(ErrorMessage = "Enter Actor Name")]
        
        public string ActorName { get; set; }

        [Required(ErrorMessage = "Enter Year of Release")]
        
        public int RealeaseYear { get; set; }
        
        [Required(ErrorMessage = "Enter director Name")]
        public string DirectorName { get; set; }
    }
}
