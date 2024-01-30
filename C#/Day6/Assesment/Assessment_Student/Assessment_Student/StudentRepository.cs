namespace Assessment_Student
{
    class StudentRepository 
    {
        Student[] students = new Student[3];
        int index = 0;
        public void CreateStudent(Student student) 
        {
            try 
            {
                if (index < students.Length)
                {
                    students[index] = student;
                    index++;
                }
                else 
                {
                    Console.WriteLine("Student record full!!,This record will not be added");
                    Console.WriteLine();
                }
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            } 
           
               
        }
        public void  UpdateStudentDetails(int Id) 
        {
            if (students == null) 
            {
                Console.WriteLine("no Student record available to modify");
                return;
            }
            try
            {
                Student student = new Student();
                int i = 0;
                int index = 0;
                foreach (Student s in students)
                {
                    if (s.ID == Id)
                    {
                        student = s;
                        index = i;
                        break;
                    }
                    i++;
                }
                if (student != null)
                {
                    Console.Write("Choose the option to Update \n1.Age \n2.Name");
                    int ch = int.Parse(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.WriteLine("Enter the age to Update");
                        sbyte age = sbyte.Parse(Console.ReadLine());
                        student.Age = age;
                        students[index] = student;
                    }
                    else if (ch == 2)
                    {
                        Console.WriteLine("Enter the Name Update");
                        string name = (Console.ReadLine());
                        student.Name = name;
                        students[index] = student;

                    }
                    else { Console.WriteLine("Wrong choice!!!!"); }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

           
        } 
        
        public Student StudentDetails(int id) 
        {
           
            if (students == null) 
            {
                return null;
            }
            try
            {
                foreach (Student s in students)
                {
                    if (s != null)
                    {
                        if (s.ID == id)
                        {

                            return s;
                        }
                    }


                }
                return null;
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public Student StudentDetails(string name) 
        {
            
            if (students == null)
            {
                return null;
            }
            try {
                foreach (Student s in students)
                {
                    if (s != null)
                    {
                        if (s.Name.Equals(name))
                        {
                            return s;
                        }
                    }


                }
                return null;
            }
            catch (Exception e) { Console.WriteLine(e.Message);
                return null;
            }
            
          
        }

        public Student[] StudentDetails(short std) 
        {
            try {
                Student[] student = new Student[students.Length];
                if (students == null)
                {
                    return null;
                }
                int i = 0;
                foreach (Student s in students)
                {
                    if (s != null)
                    {
                        if (s.Std == std)
                        {
                            student[i] = s;
                            i++;

                        }
                    }


                }
                return student;
            }
            catch (Exception e) { Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public Student[] StudentDetails(sbyte age)
        {
            try 
            {
                Student[] student = new Student[students.Length];
                if (students == null)
                {
                    return null;
                }
                int i = 0;
                foreach (Student s in students)
                {
                    if (s != null)
                    {
                        if (s.Age == age)
                        {
                            student[i] = s;
                            i++;
                        }
                    }

                }
                return student;
            }
            catch (Exception e) { Console.WriteLine(e.Message);
                return null;
            }
            
        }
        public Student[] StudentDetails(short std, char sec)
        {
            try {
                Student[] student = new Student[students.Length];
                if (students == null)
                {
                    return null;
                }
                int i = 0;
                foreach (Student s in students)
                {
                    if (s != null)
                    {
                        if (s.Std == std && s.Section == sec)
                        {
                            student[i] = s;
                            i++;
                        }

                    }

                }
                return student;
            }
            catch (Exception e) { Console.WriteLine(e.Message);
                return null;
            }
           
        }
        public Student[] StudentDetails()
        {
            try { return students; }
            catch (Exception e) { Console.WriteLine(e.Message);
                return null;
            }
           
        }

        public static void Display(Student student)
        {
            Console.WriteLine("Student Id:" + student.ID);
            Console.WriteLine("Student Name:" + student.Name);
            Console.WriteLine("Student Age:" + student.Age);
            Console.WriteLine("Student Std:" + student.Std);
            Console.WriteLine("Student Section:" + student.Section);
        }




    }
}
