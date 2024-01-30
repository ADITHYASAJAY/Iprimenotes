namespace Assignment_Inheritance
{
    class Cot : Furniture 
    {
        private string cotType;
        string capacity;
        int rate;

        override public void GetData()
        {
            base.GetData();
            Console.WriteLine("Enter Cot Type \n1.Wood\n2.Steel");

            int ch = int.Parse(Console.ReadLine());
            base.furnitureType = "Cot";
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("1.Teak Wood\n2.Rose Wood");
                        Console.WriteLine("Enter your choice");
                        ch = int.Parse(Console.ReadLine());
                        if (ch == 1)
                        {
                            cotType = "Teak Wood";
                        }
                        else if (ch == 2)
                        {
                            cotType = "Rose Wood";
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("1.Gray Steel\n2.Green Steel\n3.Brown Steel");
                        Console.WriteLine("Enter your choice");
                        ch = int.Parse(Console.ReadLine());
                        if (ch == 1)
                        {
                            cotType = "Gray Steel";
                        }
                        else if (ch == 2)
                        {
                            cotType = "Green Steel";
                        }
                        else if (ch == 3)
                        {
                            cotType = "Green Steel";
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");
                        }
                    }
                    break;
                default: 
                    {
                        Console.WriteLine("Wrong choice");
                    }
                    break;
            }
            Console.WriteLine("Enter capacity\n1.Single \n2.Double");
            ch=int.Parse(Console.ReadLine());
            if (ch == 1) 
            {
                capacity = "Single";
            }
            else if(ch==2)
            {
                capacity = "Double";
            }
            base.furnitureType = cotType;
            Console.WriteLine("Enter the Rate");
            rate = int.Parse(Console.ReadLine());

            base.totalAmt = rate * base.qty;
        }
        override public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Cot Type: " + cotType);
            Console.WriteLine("Capacity: " + capacity);
            Console.WriteLine("Rate: "+rate);
            

        }
    }
}
