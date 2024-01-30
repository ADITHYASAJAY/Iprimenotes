using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Marks
    {
        public static void Main() 
        {
            int[] marks = new int[10];
            Console.WriteLine("enter the marks");
            int totalMarks = 0;
            int minMarks = int.MaxValue;
            int maxMarks = int.MinValue;
            for(int i = 0; i < 10; i++) 
            {
                marks[i]= int.Parse(Console.ReadLine());
                totalMarks += marks[i];
                if (marks[i]<minMarks)
                    minMarks = marks[i];
                if (marks[i]>maxMarks)
                    maxMarks = marks[i];
            }

            Console.WriteLine("Total Marks: "+totalMarks);
            Console.WriteLine("Min Marks: "+minMarks);
            Console.WriteLine("Max Marks: "+maxMarks);
            Console.WriteLine("ascending order");
            int temp;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }
           
            foreach(int i in marks)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("descending order");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }

            foreach (int i in marks)
            {
                Console.WriteLine(i);
            }
        }
    }
}
