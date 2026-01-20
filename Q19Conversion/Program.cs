using System;

namespace Q19Conversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Feet: ");
            int feet = Convert.ToInt32(Console.ReadLine());

            double centimeters = 30.48 * feet;
            double result = Math.Round(centimeters,2,MidpointRounding.AwayFromZero);

            Console.WriteLine($"{feet} Feet : {result}cm");
        }
    }
}