namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //array syntax
            //datatype variableName[] = new datatype[size];
            int[] marks = new int[6];
            marks[0] = 89;
            marks[1] = 78;
            marks[2] = 67;
            marks[3]= 90;
            marks[4]= 66;
            marks[5] = 78;
            int total =0;
            Console.WriteLine("English marks: " + marks[3]);
            Console.WriteLine("Marks in all subjects");
            for(int i = 0; i < 6; i++) 
            {
                Console.WriteLine(marks[i]);
                total = total + marks[i];
            }
            Console.WriteLine("Total Marks: "+total);
            Console.WriteLine();
            foreach(int mark in marks) 
            {
                Console.WriteLine(mark);
            }

        }
    }
}
