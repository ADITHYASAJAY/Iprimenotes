﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        string[] students = new string[] { "Arya", "Hari", "Akash", "Lekshmi" };
        [HttpGet("GetAllStudents")]
        public string[] GetStudents() 
        {
            return students;
        }

        [HttpGet("GetStudentById/{id}")]
        public string GetStudent(int id) 
        {
            return students[id - 1];
        }
        [HttpPost("AddStudent/{name}")]
        public string Add(string name) 
        {
            students[0]=name;
            return "Student Added";
        }
        [HttpPut("{name}")]
        public string Update(string name) 
        {
            return "Student Updated";
        }
        [HttpDelete("{id}")]
        public string Delete(int id) 
        {
            return "Student Deleted";
        }
    }
}
