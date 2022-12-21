using System;
namespace Question8{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Enter Length in metre:");
            float length=float.Parse(Console.ReadLine());
            float cm=length*100;
            float Mm=cm*10;
            float Inch=(float)39.3*length;
            float Foot=12*length;
            double Mile=(double)0.0006213715277778*length;
            Console.WriteLine($"To CentiMetre:{cm}");
            Console.WriteLine($"To MilliMeter: {Mm}");
            Console.WriteLine($"To Inch: {Inch}");
            Console.WriteLine($"To Foot: {Foot}");
            Console.WriteLine($"To Mile: {Mile}");
        }
    }
}