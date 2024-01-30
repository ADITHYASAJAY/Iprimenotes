using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class NumberInBetween
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first number");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber < secondNumber)
            {

                for (int i = firstNumber + 1; i < secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = secondNumber + 1; i < firstNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
