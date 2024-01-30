using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Assessment_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentRepository = new StudentRepository();

            do {
                Console.WriteLine("1.Add Student \n2.Update Student \n3.Display StudentDetails\n4.Exit");
                Console.WriteLine("Enter your choice");
                int ch=int.Parse (Console.ReadLine());
                switch (ch) 
                {
                    case 1: 
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter the student Details");
                            Console.WriteLine("Enter the Id of Student:");
                            student.ID=int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the student Name");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter the age of student");
                            student.Age=sbyte.Parse(Console.ReadLine());    
                            Console.WriteLine("Enter the Std of Student");
                            student.Std=short.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Section");
                            student.Section= Convert.ToChar(Console.ReadLine());
                            studentRepository.CreateStudent(student);
                        }
                        break;
                        case 2:
                        { 
                            Console.WriteLine("Enter Id of Student to Update");
                            int Id=int.Parse((Console.ReadLine()));
                            studentRepository.UpdateStudentDetails(Id);
                        }
                        break;
                        case 3:
                        { 
                            Console.WriteLine("Students Details");
                            Console.WriteLine("1.Display student details based on ID " +
                                "\n2.Display student details based on Name " +
                                "\n3.Display all students based on std " +
                                "\n4.Display all students based on std and section " +
                                "\n5.Display all students based on age " +
                                "\n6.Display all students details");
                            int choice=int.Parse((Console.ReadLine()));
                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Enter the Id of Student:");
                                        int id = int.Parse((Console.ReadLine()));
                                        Student student = new Student();
                                        student = studentRepository.StudentDetails(id);
                                        if (student == null)
                                        {
                                            Console.WriteLine("Nothing to Display");
                                        }
                                        else
                                        {
                                            StudentRepository.Display(student);

                                        }

                                    }
                                    break;
                                case 2:
                                    {
                                        Student student = new Student();
                                        Console.WriteLine("Enter the  Name:");
                                        string name = Console.ReadLine();
                                        student = studentRepository.StudentDetails(name);
                                        if (student == null)
                                        {
                                            Console.WriteLine("Nothing to Display");
                                        }
                                        else
                                        {
                                            StudentRepository.Display(student);
                                        }


                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Enter the std ");
                                        short std = short.Parse(Console.ReadLine());
                                        Student[] student = studentRepository.StudentDetails(std);

                                        foreach (Student s in student)
                                        {
                                            if (s != null)
                                            {
                                                StudentRepository.Display(s);
                                            }
                                        }

                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine("Enter the std");
                                        short std = short.Parse(Console.ReadLine());
                                        Console.WriteLine("Enter the section");
                                        char section = char.Parse(Console.ReadLine());
                                        Student[] student = studentRepository.StudentDetails(std, section);
                                        if (student != null)
                                        {
                                            foreach (Student s in student)
                                            {
                                                if (s != null)
                                                {
                                                    StudentRepository.Display(s);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nothing to show..");
                                        }

                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine("Enter the age");
                                        sbyte age = sbyte.Parse(Console.ReadLine());
                                        Student[] student = studentRepository.StudentDetails(age);
                                        foreach (Student s in student)
                                        {
                                            if (s != null)
                                            {
                                                StudentRepository.Display(s);
                                            }
                                        }
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine("Display all students");
                                        Student[] student = studentRepository.StudentDetails();
                                        foreach (Student s in student)
                                        {
                                            if (s != null)
                                            {
                                                StudentRepository.Display(s);
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Wrong choice!!");
                                    break;
                            }

                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;

                }
                
            } while (true);
        }
        
    }
}
