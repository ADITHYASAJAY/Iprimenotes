using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingModelValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Pls Enter UserName")]
        public string UserName {  get; set; }
        [Required (ErrorMessage ="Pls Enter Password")]
        public string Password { get; set; }    
    }
}
