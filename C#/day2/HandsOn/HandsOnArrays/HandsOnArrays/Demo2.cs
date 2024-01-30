using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Demo2
    {
        public static void Main() 
        {
            int []n = { 12, 2, 3,234,44,5,33 };//dynamic array
            Console.WriteLine("Size: "+n.Length);//returns size of the array
            Console.WriteLine("Dimension: "+n.Rank);//Ranks returns dimension of array
            //sort array elements
            Array.Sort(n);
            foreach(int i in n) Console.WriteLine(i);
            Console.WriteLine();
            //reverse array elements
            Array.Reverse(n);
            foreach(int i in n)Console.WriteLine(i);    
            Console.WriteLine();
            if(Array.BinarySearch(n,12)>=0)//BinarySearch search a value in a sorted array
            {
                Console.WriteLine("Value exist");
            }
            else
            {
                Console.WriteLine("Value Not exist");
            }
        }
    }
}
