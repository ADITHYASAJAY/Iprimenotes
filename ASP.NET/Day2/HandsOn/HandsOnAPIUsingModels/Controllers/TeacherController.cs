using HandsOnAPIUsingModels.Models;
using HandsOnAPIUsingModels.Repositories;
using HandsOnAPIUsingModels.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository teacherRepository;

        public TeacherController() 
        {
            teacherRepository = new TeacherRepository();
        }
        [HttpGet,Route("GetAllTeachers")]
        public IActionResult GetAll() // return any type of data as a http response
        {
            try {
                List<Teacher> teachers
                     = teacherRepository.GetAll();
                //statusCode use to send any json data with status code
                return StatusCode(200, teachers);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex);
            }
            
        }
        [HttpGet,Route("GetTeacherById/{id}")]

        public IActionResult GetTeacher(int id) 
        {
            Teacher teacher = teacherRepository.GetTeacher(id);
            if (teacher != null)
            {
                return StatusCode(200, teacher);
            }
            else
                return StatusCode(404, new JsonResult("Invalid Id"));

        }

        [HttpGet,Route("GetTeachersBySubject/{subject}")]

        public IActionResult GetTeacherBySubject( string subject)
        {
            try {
                return StatusCode(200, teacherRepository.GetAll());
            } catch (Exception) { throw; }
        }

        [HttpPost, Route("AddTeacher")]
        public IActionResult Add(Teacher teacher)
        {
            try
            {
                teacherRepository.Add(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost, Route("UpdateTeacher")]
        public IActionResult Update(Teacher teacher)
        {
            try
            {
                teacherRepository.Update(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete, Route("DeleteById /{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                teacherRepository.Delete(id);
                return StatusCode(200, "deleted successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }
        

    }
}
