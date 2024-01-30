using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterface
{
    class Student 
    {
        int Id { get; set; }    
        public string Name { get; set; }
    }
    interface IStudentRepository 
    {
        Student GetById(int id);
        void Update(Student student);
        void DeleteById(int id);
        void AddStudent(Student student);
    }
    class StudentRepository : IStudentRepository
    {
        public Student[] students = new Student[3];
        int idx = 0;
        public void AddStudent(Student student)
        {
            if (idx < students.Length) 
            {
                students[idx++] = student;
            }
            
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
    internal class Demo1
    {
    }
}
