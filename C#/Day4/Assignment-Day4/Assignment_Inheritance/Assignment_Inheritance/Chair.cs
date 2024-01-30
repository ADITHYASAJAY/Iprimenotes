namespace Assignment_Inheritance
{
    class Chair : Furniture 
    {
        int rate;
        string purpose;
        string chairType;
        string chairColor;

        
        override public void GetData() 
        {
           
            Console.WriteLine("Enter choice of purpose \n1.Home\n2.Office");
            int ch=int .Parse(Console.ReadLine());
            if (ch == 1) 
            {
                purpose = "Home";
            }
            else if (ch == 2) 
            {
                purpose = "Office";
            }
            Console.WriteLine("Enter ChairType \n1.Wood \n2.Steel \n3.Plastic");
            ch =int.Parse(Console.ReadLine());
            base.furnitureType = "Chair";
            switch (ch) 
            {
                case 1:
                    {
                        
                        Console.WriteLine("1.Teak Wood \n2.Rose Wood");
                        Console.WriteLine("Enter your choice");
                        ch =int .Parse(Console.ReadLine());
                        if (ch == 1) 
                        {
                            chairType = "Teak Wood";
                        }
                        else if(ch == 2) 
                        {
                            chairType = "Rose Wood";
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");                             
                        }
                    }
                    break;
                case 2: 
                    {
                        
                        Console.WriteLine("1.Gray Steel\n2.Green Steel \n3.Brown Steel");
                        Console.WriteLine("Enter your choice");
                        ch = int.Parse(Console.ReadLine());
                        if (ch == 1)
                        {
                            chairType = "Gray Steel";
                        }
                        else if (ch == 2)
                        {
                            chairType = "Green Steel";
                        }
                        else if (ch == 3)
                        {
                            chairType = "Green Steel";
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");
                        }
                    }
                    break;
                case 3: 
                    {
                        
                        Console.WriteLine("1.Green \n2.Red \n3.Blue \n4.White");
                        Console.WriteLine("Enter your choice");
                        ch = int.Parse(Console.ReadLine());
                        chairType = "Plastic";
                        if (ch == 1)
                        {
                            chairColor = "Green";
                        }
                        else if (ch == 2)
                        {
                            chairColor = "Gray Steel";
                        }
                        else if (ch == 3)
                        {
                            chairColor = "Red";
                        }
                        else if(ch == 4)
                        {
                            chairColor = "Red";
                        }
                        else
                        {
                            Console.WriteLine("Wrong choice");
                        }
                    }
                    break;
                default: 
                    Console.WriteLine("Wrong choice");
                    break;
            
            }

            base.GetData();
            Console.WriteLine("");
            Console.WriteLine("Enter the Rate");
            rate = int.Parse(Console.ReadLine());        
            base.totalAmt = rate * base.qty;

        }
        override public void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Purpose:"+purpose);
            Console.WriteLine("Chair Type: "+chairType);
            Console.WriteLine("Rate:"+rate);
            if (chairColor != null) 
            {
                Console.WriteLine("Chair Color: " + chairColor);
            }
        }
    }
}
