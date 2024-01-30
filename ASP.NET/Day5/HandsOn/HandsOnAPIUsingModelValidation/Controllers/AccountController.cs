using HandsOnAPIUsingModelValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        List<Login> logins = new List<Login>() 
        {
            new Login(){ UserName = "Anna" ,Password="12345"},
            new Login(){ UserName = "Merry" ,Password="12345"},
            new Login(){ UserName = "Manoj" ,Password="12345"},
            new Login(){ UserName = "Chandra" ,Password="12345"},
            new Login(){ UserName = "Joy" ,Password="12345"},

        };
        List<User> users = new List<User>() 
        {
            new User(){Id=454,Name="Manoj",Email="manoj@gmail.com",Username="Manoj",Password="12345" },
        };
        [HttpPost]
        public IActionResult Validate(Login login) 
        {
            try {
                if (ModelState.IsValid)
                {


                    //var user = logins.SingleOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
                    var user = (from l in logins
                                join u in users
                                on l.UserName equals u.Username
                                where u.Username == login.UserName
                                && u.Password == login.Password
                                select u).SingleOrDefault();
                    if (user != null)
                    {
                        return StatusCode(200, user);
                    }
                    else
                    {
                        return StatusCode(200, new JsonResult("Invalid User credentials"));

                    }
                }
                else 
                {
                    return BadRequest(login);
                }
            }
            catch (Exception ex) 
            {
                return StatusCode(501, ex);
            }    
        }

        [HttpPost,Route("Register")]
        public IActionResult Register([FromBody]User user)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    user.Id = new Random().Next(1000, 9999);
                    users.Add(user);
                    return Ok(user);
                }
                else 
                {
                    return BadRequest();
                }
            }
            catch (Exception ex) 
            {
                return StatusCode(501, ex);
            }
        }
    }
}
