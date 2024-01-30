namespace Assignment_Collectios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 10 numbers");
            for (int i = 0; i < 10; i++) 
            {
                int number =int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            Console.WriteLine("Sorted numbers");
            numbers.Sort();
            foreach (int i in numbers) 
            {
                Console.WriteLine(i);
            }


        }
    }
}
