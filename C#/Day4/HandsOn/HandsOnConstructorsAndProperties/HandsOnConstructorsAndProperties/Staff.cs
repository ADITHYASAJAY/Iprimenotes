using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Staff
    {
        private int id;
        public string name;

        public Staff(int id,string name) 
        {
            this.id = id;
            this.name = name;
        }
        public Staff(Staff staff) 
        {
            this.id=staff.id;
            this.name = staff.name;
        }
        public void Display() 
        {
            Console.WriteLine($"Id:{id} Name:{name}");
        }
    }

    class Test_Staff 
    {
        public static void Main() 
        {
            Staff s = new Staff(343, "Rajan");
            s.Display();
            Staff[] staffs = new Staff[4];
            staffs[0]= s;

           
            staffs[1]= new Staff(43,"mary");
            staffs[2] = new Staff(55,"ann");
            staffs[3] = new Staff(s);
            s.name = "hari";

            foreach (Staff staff in staffs) 
            {
                staff.Display();
            }
        } 
    }
}
