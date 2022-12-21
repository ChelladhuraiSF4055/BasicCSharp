using System;
namespace Question3{
    class Program{
        public static void Main(string[] args)
        {
           Console.WriteLine("Enter the amount of Celsius:");
           float cel=float.Parse(Console.ReadLine()); 
           float kel=(float)(cel+ 273.15);
           float fahrenheit=(float)((cel*9)/5)+32;
           Console.Write($"Kelvin = {kel}\n");
           Console.Write($"Fahrenheit = {fahrenheit}");
        }
    }
}
