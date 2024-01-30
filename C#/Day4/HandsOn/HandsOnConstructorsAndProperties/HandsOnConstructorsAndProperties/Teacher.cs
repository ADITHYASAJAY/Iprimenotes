using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Teacher
    {
        private int teacherId;
        private string teacherName;
        private int age;
        public int ID { get { return teacherId; }
            set {
                if (value > 0)
                    teacherId = value;
                else
                    Console.WriteLine("Invalid Id");
            }
        }
        public string Name { get { return teacherName; }
            set {
                if (value != null) 
                {
                    teacherName = value;
                   
                }
                else 
                {
                    Console.WriteLine("Invalid name");
                }
                
            } }

        public int Age
        {
            get { return age; }
            set { 
                if(value>24 && value < 29) 
                {
                    age = value;
                }
                else 
                {
                    Console.WriteLine("Not eligible for this Post!!!");
                }
            }
        }
    }

    class Test_Teacher 
    {
        public static void Main() 
        {
            Teacher teacher = new Teacher();    
            teacher.ID = -1;
            teacher.Age = 31;
            teacher.Name = null;

            Teacher teacher1 = new Teacher();   
            teacher1.ID = 1;
            teacher1.Age = 27;
            teacher1.Name = "hari";

            Console.WriteLine($"ID:{teacher.ID} Name:{teacher.Name} Age:{teacher.Age}");
            Console.WriteLine($"ID:{teacher1.ID} Name:{teacher1.Name} Age:{teacher1.Age}");
        } 
    }
}
