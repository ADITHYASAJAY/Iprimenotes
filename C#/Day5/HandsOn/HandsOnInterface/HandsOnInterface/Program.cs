namespace HandsOnInterface
{
    interface IShape 
    {
        void Area();
    }
    class Circle: IShape 
    {
        private double radius;
        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public void Area()
        {
            Console.WriteLine("Area of Circle:" + Math.PI * radius * radius);
        }

        public void GetShape() 
        {
            Console.WriteLine("Its a circle");
        }
    }

    class Square : IShape 
    {
        private int length;

        public void Area() 
        { 
            Console.WriteLine("Area of square"+ length*length);
        }
        public void GetShape() 
        {
            Console.WriteLine("Its a square");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(110);
            circle.Area();
            
            Circle circle2 = new Circle(10);
            circle2.Area();
            circle2.GetShape();




        }
    }
}
