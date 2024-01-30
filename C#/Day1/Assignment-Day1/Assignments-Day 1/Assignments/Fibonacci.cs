using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Fibonacci
    {
        static void Main() {

            int prev = 0;
            int current = 1;
            int next = current + prev;

            Console.WriteLine(prev);
            Console.WriteLine(current);
            while(next<=40)
            {
               prev= current;
                current = next;
                Console.WriteLine(current);
                next = current + prev;
            }

        }
    }
}
