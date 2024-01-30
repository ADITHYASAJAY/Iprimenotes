using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class AgeException : Exception 
    {
        int age;
        string message;
        public AgeException(int age) 
        {
            message = $"{age} is not applicable for appling exam and\n age shold be between 12 and 15";
        }

        public override string Message { get { return message; } }  

        public string Msg {
            get { return message; }
        }
    }
    internal class Student
    {
        public void ApplyExam(int age) 
        {
            try 
            {
                
                if(age>12 && age <= 15) 
                {
                    Console.WriteLine("Applied for Exam Successfully!!");
                }
                else 
                {
                    throw new AgeException(age);
                }
            }
            catch(AgeException e) 
            {
                Console.WriteLine(e.Message);
            }
        }

       
    }
    class Test_Student 
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.ApplyExam(5);
            s.ApplyExam(13);
        }
    }
}
