using System.ComponentModel.DataAnnotations;

namespace UserAPI.Model
{
    public class User
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Email {  get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
