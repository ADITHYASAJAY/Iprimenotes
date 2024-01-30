using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo7
    {
        static void Main() 
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Rose");
            stack.Push("Lilly");
            stack.Push("lotus");
            stack.Push("Jasmine");

            foreach (var item in stack)
                Console.WriteLine(item);

            Console.WriteLine();

            Console.WriteLine("Picked item"+ stack.Peek());
            Console.WriteLine("Removed item"+stack.Pop());

            Console.WriteLine();    

            foreach(var item in stack)
                Console.WriteLine(item);
            Console.WriteLine();


        }
    }
}
