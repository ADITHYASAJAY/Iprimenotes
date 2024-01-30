using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class StringCompare
    {
        public static void Main() 
        {
            Console.WriteLine("Enter the first  string");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter the second  string");
            string secondString = Console.ReadLine();
            if (string.Equals(firstString, secondString)) 
            {
                Console.WriteLine("They are Equal");
            }
            else 
            {
                Console.WriteLine("They are not Equal");
            }
        }
    }
}
