using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class SquareSeries
    {
        static void Main() 
        {
            Console.WriteLine("Enter the limit");
            int limit=int.Parse(Console.ReadLine());

            for(int i=0; i<limit;i++)
            {
                Console.Write(i*i+", ");
            }
        }
    }
}
