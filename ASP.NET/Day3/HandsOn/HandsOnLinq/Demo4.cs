using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo4
    {
        static void Main() 
        {
            DateTime orderDate;
            orderDate = DateTime.Now;
            Console.WriteLine(orderDate);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            orderDate = new DateTime(2000, 2, 23);
            Console.WriteLine(orderDate);
            var obj = new { Id = 1, Name = "Rana" };//anoymous object
            Console.WriteLine(obj.Id+" "+obj.Name);
        }
    }
}
