using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
  
    internal class Demo5
    {
        static void Main() 
        {
            SortedDictionary<int,string> obj = new Dictionary<int,string>();
            obj.Add(7567, "faris");
            obj.Add(756, "manoj");
            obj.Add(75347, "ann");
            obj.Add(75673, "George");
            string name = obj[756];
            Console.WriteLine(name);
            foreach (var key in obj.Keys) 
            {
                Console.WriteLine($"Id:{key} Name:{obj[key]}");
            }
            Teacher t1 = new Teacher() { Id=5435,Name="Adithya", Email="adithya@gmail.com", Mobile="8086302462" ,School="Dns"};
            Teacher t2 = new Teacher() { Id = 535, Name = "Akash", Email = "akash@gmail.com", Mobile = "8136312462", School = "sns" };
            Teacher t3 = new Teacher() { Id = 545, Name = "Aromal", Email = "aromal@gmail.com", Mobile = "8186313463", School = "Dns" };
            Dictionary<int,Teacher> ob1 = new Dictionary<int,Teacher>();
            ob1.Add(t1.Id, t1);
            ob1.Add(t2.Id, t2);
            ob1.Add(t3.Id, t3);
            Teacher t = ob1[t1.Id];
            Console.WriteLine($"Name:{t.Name} Email:{t.Email} Mobile:{t.Mobile} School{t.School}");
    }
}
