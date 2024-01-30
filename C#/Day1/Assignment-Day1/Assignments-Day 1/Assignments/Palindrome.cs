using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Palindrome
    {
        public static void Main() 
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int len = s.Length;
            int right = len - 1;
            bool flag = true;
            for (int left = 0; left < right; left++, right--) 
            {
                if (s[left] != s[right]) 
                {
                    flag = false;                
                }
            }
            if (flag)
                Console.WriteLine($"String {s} is palindrome");
            else
                Console.WriteLine($"String {s} is not palindrome");
        }
    }
}
