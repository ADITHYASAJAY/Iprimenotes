using System.Transactions;

namespace Assignment_Inheritance
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture furniture;
            Console.WriteLine("Enter the Your Choice type\n1.Chair\n2.Cot");
            int ch = int.Parse(Console.ReadLine());
            switch (ch) 
            {
                case 1:
                    furniture = new Chair();
                    furniture.GetData();
                    Console.WriteLine();
                    furniture.ShowData();
                    break;
                case 2:
                    furniture = new Cot();
                    furniture.GetData();
                    Console.WriteLine();
                    furniture.ShowData();
                    break;  
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
            
        }
    }
}
