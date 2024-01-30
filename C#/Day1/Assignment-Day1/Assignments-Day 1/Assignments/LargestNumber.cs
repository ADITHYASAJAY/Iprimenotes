using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class LargestNumber
    {
        static void Main() 
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber) 
            {
                if (firstNumber > thirdNumber)
                    Console.WriteLine(firstNumber+" is the largest Number");
                else
                    Console.WriteLine( thirdNumber + " is the largest Number");
            }
            else
            {
                if(secondNumber>thirdNumber)
                    Console.WriteLine(secondNumber + " is the largest Number");
                else
                    Console.WriteLine(thirdNumber + " is the largest Number");
            }
        }
    }
}
