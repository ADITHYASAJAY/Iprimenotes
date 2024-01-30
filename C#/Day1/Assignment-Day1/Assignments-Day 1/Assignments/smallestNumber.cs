using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class smallestNumber
    {
        static void Main() 
        {
            int[] arr = new int[5] { 33, 4, 35, 36, 7 };

            int smallest = int.MaxValue;
            foreach(int i in arr)
            {
                if(i< smallest)
                    smallest = i;
            }
            Console.WriteLine(smallest+" is the smallest");
        }
       
    }
}
