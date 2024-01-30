using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]//Route specifies url pattern
    [ApiController]//attribute
    public class TeacherController : ControllerBase
    {
        [HttpGet("Greet")]//this method is invoked by get request
        //request http://localhost:5291/api/Teacher
        public string Greet() 
        {
            return "Good Morning, Teachers";//sents this message as a http request
        }
        [HttpGet("")]
        public string[] GetTeachers() 
        {
            return new string[] { "Roopam","Sanu","Santhosh","Karthik"};
        }

        [HttpGet("GetTeachersByStd/{std}")]
        public string[] GetTeachersByStd(string std)
        {
            return new string[] { "Roopam", "Sanu", "Santhosh", "Karthik" };
        }
        [HttpGet]
        public string Hello() 
        {
            return "Hello World!!!";
        }
    }
}
