using System.ComponentModel.DataAnnotations;
using System.Data;
namespace HandsOnAPIUsingModelValidation.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Gender")]
        public string Gender {  get; set; }
        [Range(18,90,ErrorMessage ="Age should be between 18 to 90")]
        public int Age {  get; set; }
        public DateTime DoB {  get; set; }
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage ="Invalid EmailID")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Mobile")]
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid MobileNo:")]
        public string Mobile{ get; set; }
        [Required(ErrorMessage = "Enter Username")]
        public string Username {  get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [RegularExpression("[a-zA-z)-9]{6,8}",ErrorMessage ="Password shouls be 6 to 8 chars")]
        public string Password { get; set; }
    }
}
