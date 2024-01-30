using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Enroll
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public Enroll(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
    class StudentEnroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public StudentEnroll(int id, string name,
                           string cname)
        {
            this.Id = id;
            this.Name = name;
            this.CourseName = cname;
        }
    }
    internal class Demo5
    {
        public static void Main() 
        {
            Student[] students =
            {
                new Student(1,"hari"),
                new Student(2,"vishnu"),
                new Student(3,"leo"),
                new Student(4,"aromal"),
                new Student(5,"akash"),
            };

            Enroll[] enrollments =
            {
                new Enroll(1,"SAP"),
                new Enroll(2,".NET"),
                new Enroll(1,"Java"),
                new Enroll(3,"Flutter"),
                new Enroll(4,"SAP"),
                new Enroll(4,"Java"),
                new Enroll(5,"SAP"),
                new Enroll(1,"Flutter"),
            };


            var result = from s in students
                         join e in enrollments
                         on s.Id equals e.Id
                         select new StudentEnroll(s.Id, s.Name, e.CourseName);

            foreach (var studentenroll in result) 
            {
            
                Console.WriteLine($"Id:{studentenroll.Id} Name:{studentenroll.Name} Course:{studentenroll.CourseName}");
            }
        }
    }
}
