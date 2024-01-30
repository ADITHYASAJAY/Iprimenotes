using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Demo1
    {
        static void Main() 
        {
            try
            {
                Console.WriteLine("Enter a,b values");
                byte a=byte.Parse(Console.ReadLine());  
                byte b=byte.Parse(Console.ReadLine());
                if (b == 0) 
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
                
                
                Console.WriteLine("Thank you");
            }
            catch (DivideByZeroException e) 
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter only numbers");
            }
            catch(Exception exc) 
            {
                Console.WriteLine(exc.Message);
            }
        }
        
    }
}
