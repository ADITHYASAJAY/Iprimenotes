using HandsOnAPIUsingModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>() {
            new Student { Id=564564,Name="Hani",Age=12,Std="8"},
            new Student { Id=564774,Name="Akash" ,Age=13,Std="8"},
            new Student { Id=567564,Name="Aromal" ,Age=12,Std="8"},
            new Student { Id=564574,Name="Hari", Age = 13, Std ="8"}
        };
        [HttpPost,Route("AddStudent")]
        public Student Add(Student student) //pass the student details through the request body
        {
            students.Add(student);
            return student;
        }

        [HttpGet, Route("GetAll")]

        public List<Student> GetStudents() 
        {
            return students;
        }

        [HttpGet, Route("GetStudentById/{id}")]
        public Student GetStudentById(int id) 
        {
            foreach(var item in students)
            {
                if(item.Id==id)
                    return item;
            }
            return null;
        }
        [HttpGet, Route("GetStudentByName/{name}")]

        public Student GetStudentByName(string name) 
        {
            foreach (var item in students)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
        [HttpGet, Route("GetStudentByIdAndName/{id}/{name}")]

        public Student GetStudentByIdAndName(int id, string name) 
        {
            foreach (var item in students)
            {
                if (item.Id == id&& item.Name==name)
                    return item;
            }
            return null;
        }
        [HttpDelete,Route("DeleteStudent/{id}")]
        public string Delete(int id) 
        {
            try 
            {
                Student student = null;
                foreach (var item in students)
                {
                    if (item.Id == id)
                    { 
                        student = item;
                        break;
                    }
                }
                if (student == null)
                {
                    return "Invalid name";
                }
                else 
                {
                    students.Remove(student);
                    return "Successfully deleted";
                }

            }
            catch(Exception ex) 
            {
                throw ex;
            }
            
        }

    }
}
