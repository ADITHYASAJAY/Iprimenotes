﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MultiplicationTable
    {
        static void Main() 
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine()); 
            for(int i = 1; i <= 20; i++) 
            {
                Console.WriteLine($"{number} * {i} = "+ (number*i));
            }
        }
    }
}
