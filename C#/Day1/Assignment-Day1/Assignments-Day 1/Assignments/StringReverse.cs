using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class StringReverse
    {
        static void Main() 
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            char[] chararr = s.ToCharArray();
            int len = chararr.Length;
            StringBuilder reverseString = new StringBuilder();
            for(int i= len-1; i>=0; i--) 
            {
                reverseString.Append(chararr[i]);
            }
            Console.WriteLine("Reveresed string: "+reverseString);
        }
    }
}
