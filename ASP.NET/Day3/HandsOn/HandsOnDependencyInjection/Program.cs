namespace HandsOnDependencyInjection
{
    class Student 
    {
        public int Id;
        public string Name;
        public Student(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }

    class Register 
    {
        Student student;
        public Register(Student student) 
        {
            this.student = student;
        }
        public void Details()
        {
            Console.WriteLine($"Id:{student.Id} Name:{student.Name}");
        }
    }

    class School 
    {
        Register register;
        public School(Register register) 
        {
            this.register = register;
        }
        public void CompleteRegister() 
        {
            Console.WriteLine("Registered Student Details");
            register.Details();

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register(new Student(12,"adithya"));
            //register.Details();

            School school = new School(register);
            school.CompleteRegister();

        }
    }
}
