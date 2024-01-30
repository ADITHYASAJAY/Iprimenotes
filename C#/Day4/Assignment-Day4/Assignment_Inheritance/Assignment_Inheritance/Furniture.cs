namespace Assignment_Inheritance
{
    class Furniture
    {
        public int orderId;
        public DateTime orderDate;
        public string furnitureType;
	    public int qty;
        public int totalAmt;
        public string paymentMode;
        public Furniture() 
        {
            this.orderId = new Random().Next(); 
            this.orderDate = DateTime.Now;
        }
        public virtual void  GetData() 
        {
            Console.WriteLine("Enter quantity");
            qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter paymentMode \nEnter choice \n1.Credit\n2.Debit");
            int ch = int .Parse(Console.ReadLine());
            switch (ch) 
            {
                case 1:
                    paymentMode = "Credit";
                    break; 
                case 2:
                    paymentMode = "Debit";
                    break; 
                default: Console.WriteLine();
                    break; 
            }


        }
        public virtual void ShowData() 
        {
            Console.WriteLine("OrderId: "+orderId);
            Console.WriteLine("OrderDate: " + orderDate);
            Console.WriteLine("Furniture Type: " + furnitureType);
            Console.WriteLine("Quantity: " + qty);
            Console.WriteLine("Total Amount: " + totalAmt);
            Console.WriteLine("Payment Mode: " + paymentMode);
           
        }

    }
}
