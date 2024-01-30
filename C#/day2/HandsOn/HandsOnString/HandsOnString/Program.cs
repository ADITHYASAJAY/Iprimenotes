namespace HandsOnString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1.A string is a reference datatype
            2. strings are of two types a. Immutable strings(not dynamic in nature)
            b.Mutable strings (dynamic in nature)
            3.Immuatable strings(string)
            4.mutable string(StringBuilder)
             */
            string str = "All gliters are not gold";
            Console.WriteLine("char at 5th index " + str[4]);
            Console.WriteLine("length: " + str.Length);
            Console.WriteLine("UpperCase: " + str.ToUpper());
            str.ToUpper();
            Console.WriteLine(str); //strings are not dynamic in nature
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.Replace("g", "G")); //replace chat
            Console.WriteLine(str.Replace("gold", "diamond")); //replace sub-string
            Console.WriteLine(str.IndexOf('g'));
            Console.WriteLine(str.LastIndexOf('g'));
            Console.WriteLine(str.Remove(11));
            Console.WriteLine(str.Remove(4, 7));
            string[] str1 = str.Split(' '); //based of white space chat str is splied into string array
            foreach (string s in str1)
                Console.WriteLine(s);
            string[] ss = { "I", "Love", "Cricket" };
            string result = string.Join("-", ss);
            Console.WriteLine(result);
            string s1 = "David";
            string s2 = "David";
            if (s1.Equals(s2)) //Equals method return true when strings are equal
            {
                Console.WriteLine("strings are equal");
            }
            else
                Console.WriteLine("strings are not equal");

            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase)) //Equals method return true when strings are equal and overload is used to ignore case sensitivity
            {
                Console.WriteLine("strings are equal");
            }
            else
                Console.WriteLine("strings are not equal");

        }
    }
   }

