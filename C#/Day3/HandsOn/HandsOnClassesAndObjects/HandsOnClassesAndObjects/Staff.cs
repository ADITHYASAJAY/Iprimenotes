using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Staff
    {
        public int staffId;
        public string staffName;
        public static string school;
        public static string branch;
        public const string city = "Hyderabad";
        public string Display() 
        {
            return $"Id: {staffId}, Name: {staffName}, School: {school} Branch: {branch} City: {city}";
        }

        static void Main()
        {
            Staff.school = "DPS";
            Staff.branch = "JublisHills";
            Staff s1= new Staff() {staffId=65656, staffName="leo" };
            Staff s2= new Staff() { staffId=76887 , staffName="aromal"};
            Staff s3 = new Staff() { staffId=54454, staffName="akash"};
            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());    
            Console.WriteLine(s3.Display());
            Staff.branch = "Hitechcity";
            Staff s4 = new Staff() { staffId=656565, staffName="vishnu"};
            Staff s5 = new Staff() { staffId=87896,staffName="anandu"};
            Console.WriteLine (s4.Display());
            Console.WriteLine(s5.Display());

        }
    }
}
