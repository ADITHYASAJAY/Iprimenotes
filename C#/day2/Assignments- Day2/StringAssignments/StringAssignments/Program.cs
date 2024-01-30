using System;
using System.Security.Cryptography;
namespace StringAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine("Character at index 12:"+s1[12]);
            Console.WriteLine("The string contains'is' :"+s1.Contains("is"));
            
            string result = string.Join(" ",s1,"and killed it");
            Console.WriteLine("Joined string :"+result);

            if (s1.EndsWith("dogs")) 
            {
                Console.WriteLine("string ends with dogs");
            }
            else {
                Console.WriteLine("string does not end with dogs");
            }
            
            string s2 = "The quick brown Fox jumps over the lazy Dog";
            
            if (s1.Equals(s2)) 
            {
                Console.WriteLine("The strings are Equal");
            }
            else
            {
                Console.WriteLine("The strings are not  Equal");
            }

            string s3 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
           
            if (s1.Equals(s3))
            {
                Console.WriteLine("The strings are Equal");
            }
            else
            {
                Console.WriteLine("The strings are not Equal");
            }
            string s4 = "The quick brown Fox jumps over the lazy Dog";
            if (s1.Equals(s4, StringComparison.OrdinalIgnoreCase)) 
            {
                Console.WriteLine("strings are equal");
            }
            else { }
                Console.WriteLine("strings are not equal");

            Console.WriteLine("Length of the string: "+s1.Length);

            Console.WriteLine("String after replacing 'The' with 'A':"+s1.Replace("The", "A"));
            Console.WriteLine();

            string[] arr = s1.Trim().Split("jumps");
            for(int i = 0; i < 2; i++) 
            {
                Console.WriteLine($"String {i} :"+arr[i]);
            }

            string[] stringarr = s1.Trim().Split(" ");
            Console.WriteLine();
            Console.WriteLine("Animal :"+stringarr[3]);
            Console.WriteLine();
            Console.WriteLine("Animal :" + stringarr[8]);
            Console.WriteLine();
            Console.WriteLine("Lowercase: "+s1.ToLower());
            Console.WriteLine();
            Console.WriteLine("Uppercase: "+s1.ToUpper());

            Console.WriteLine();
            Console.WriteLine("First index of 'a' :"+s1.IndexOf("a"));
            Console.WriteLine();
            Console.WriteLine("Last index of 'e' :"+s1.LastIndexOf("e"));
            Console.WriteLine();
            Console.WriteLine("Enter home directory");
            string dir = Console.ReadLine();
            Console.WriteLine($@"{dir}/WebApps/Images");


            Console.WriteLine();
            string[] poem = new string[6] {
                "I WANDER'd loney as a cloud",
                "That floats on high o'er vales and hill,",
                "When all at once I saw a crowd",
                "A host, of golden daffodils;Beside the lake,",
                "beneath the trees,",
                "Fluttering and dancing in the breeze.",
                

            };
            foreach (string item in poem) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
