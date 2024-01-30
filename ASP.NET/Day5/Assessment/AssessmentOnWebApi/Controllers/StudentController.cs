using AssessmentOnWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentOnWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        [HttpPost, Route("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            try 
            {
                studentRepository.AddStudent(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try 
            {
                var students = studentRepository.GetAllStudent();
                return StatusCode(200, students);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetAllStudentsBySkill/{skill}")]
        public IActionResult GetAllStudentsBySkill(string skill)
        {
            try 
            {
                var students = studentRepository.GetStudentsBySkill(skill);
                return StatusCode(200, students);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetAllStudentsByQualification/{qualification}")]
        public IActionResult GetAllStudents(string qualification)
        {
            try 
            {
                var students = studentRepository.GetStudentsByQualification(qualification);
                return StatusCode(200, students);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            try 
            {
                var student = studentRepository.GetStudentById(id);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpPut, Route("UpdateStudentSkill /{id}/{skill}")]
        public IActionResult UpdateStudentBySkill(int id,string skill)
        {
            try 
            {
                studentRepository.UpdateStudentBySkill(id,skill);
                return StatusCode(200, "Skill Updated");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpPut, Route("UpdateStudentQualification/{id}/{qualification}")]
        public IActionResult UpdateStudentByQualification(int id, string qualification)
        {
            try 
            {
                studentRepository.UpdateStudentByQualification(id, qualification);
                return StatusCode(200, "Qualification Updated");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpDelete,Route("DeleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try 
            {
                studentRepository.DeleteStudent(id);
                return StatusCode(200, "Student Deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

    }
}
