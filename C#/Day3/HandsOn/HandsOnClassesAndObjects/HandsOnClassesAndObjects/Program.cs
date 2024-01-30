namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student student = new Student(); ;
            student.name = "adithya";
            student.id = 1;
            student.age = 12;
            student.gender = 'M';
            student.Display();

            Student s2 = new Student();
            s2.Display();

            Student s3 = new Student()
            {
                age = 12,
                id = 1,
                name = "hari",
                gender='M'
            };
            s3.Display();

            //Student s4 = null;
            //s4.id = 2;
            //s4.name = "adi";
            //s4.gender = 'M';
            //s4.Display();

            Student[] students = new Student[3];
            students[0] = new Student()
            {
                age = 12,
                name = "akash",
                gender='M',
                id = 1767
            };
            students[1] = new Student()
            {
                age = 14,
                name = "sankar",
                gender = 'M',
                id = 17637
            };
            students[2] = new Student()
            {
                age = 14,
                name = "hari",
                gender = 'M',
                id = 17367
            };
            foreach(Student s in students) 
            {
                s.Display();
            }
        }
    }
}

