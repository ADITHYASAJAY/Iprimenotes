using HandsOnAPIWithEFCodeFirst.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIWithEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyContext _context;
        public StudentController() 
        {
            _context = new MyContext();
        }
        //EndPoints
        [HttpPost,Route("AddStudent")]
        public IActionResult Post([FromBody] Student student) 
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet,Route("GetAllStudents")]
        public IActionResult GetAllStudents() 
        {
            try 
            {
                List<Student> students = _context.Students.ToList();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet,Route("Get/{id}")]
        public IActionResult GetStudent(int id) 
        {
            try 
            {
                Student student = _context.Students.Find(id);//for primary key
                //Student student = _context.Students.SingleOrDefault(x => x.Id == id);for non primary
                return StatusCode(200, student);
            }
            catch (Exception) {
                throw;
            }   
          
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete(int id) 
        {
            try 
            {
                Student student = _context.Students.Find(id);
                _context.Students.Remove(student);
                _context.SaveChanges();
                return Ok(new JsonResult("Student Deleted",student));
            }
            catch (Exception) 
            {
                throw;
            }
        }

    }
}
