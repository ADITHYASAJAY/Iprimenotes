using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TemperatureConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature(Fahrenheit)");
            double temperatureInFahreneit = double.Parse(Console.ReadLine());
            double temperatureInDegree = (temperatureInFahreneit - 32) * (5 / 9);
            Console.WriteLine("Temperature in Celsius :" + (temperatureInDegree));
        }
    }
}
