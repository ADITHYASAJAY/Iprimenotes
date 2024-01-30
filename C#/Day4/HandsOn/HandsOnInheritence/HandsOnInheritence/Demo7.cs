using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritence_1
{
    //method overriding is a concept of re-defining or extending base functions in devired class
    class Staff
    {
        public int staffId;
        public string staffName;

        public Staff(int staffId, string staffName)
        {
            this.staffId = staffId;
            this.staffName = staffName;
        }
        public virtual void Display()
        {
            Console.WriteLine($"ID:{staffId} Name:{staffName}");
        }
    }
    class Princple : Staff
    {
        public string level;

        public Princple(int staffId, string staffName, string level) : base(staffId, staffName)
        {
            this.level = level;
        }

        public override void Display() //new keyword is requred when to defind base functiona in derived class
        {
            base.Display(); //invokes staff display function
            Console.WriteLine($"Level:{level}");
        }
    }
    internal class Demo7
    {
        static void Main()
        {
            Staff obj = null;
            Console.WriteLine("1.Teacher");
            Console.WriteLine("2.Principal");
            Console.WriteLine("Enter u r choice");
            int ch = int.Parse( Console.ReadLine() );
            switch (ch) 
            {
                case 1: 
                    {
                        obj = new Staff(2323, "Rinku");
                        obj.Display();
                    }
                    break;
                    case 2: 
                    {
                        obj = new Princple(51425, "Ajay", "Vice-Princepal");
                        obj.Display();
                    } break;  
                    default: { Console.WriteLine("Invalid choice"); }
                    break;  
            }
        }
    }
}
