using HandsOnEFCodeFirst_Demo2.Entities;
using HandsOnEFCodeFirst_Demo2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFCodeFirst_Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IRepository<Student> studentRepository;
        public StudentController(IRepository<Student> studentRepository) 
        {
            this.studentRepository = studentRepository;  
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add([FromBody] Student student) 
        {
            try 
            {
                studentRepository.Add(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet,Route("GetAll")]
        public IActionResult GetAll() 
        {
           
            try {
                var students = studentRepository.GetAll();
                return StatusCode(200, students);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet,Route("GetById/{id}")]
        public IActionResult Get(int id) 
        {
            try 
            {
                var student = studentRepository.Get(id);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut,Route("UpdateStudent")]
        public IActionResult Put([FromBody]Student student) 
        {
            try 
            {
                studentRepository.Update(student);
                return StatusCode(200,"Updated");    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id) 
        {
            try 
            {
                studentRepository.Delete(id);
                return StatusCode(200, "Deleted Student");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
