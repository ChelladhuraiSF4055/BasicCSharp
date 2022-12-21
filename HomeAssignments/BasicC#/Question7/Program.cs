using System;
namespace Question7{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("a-");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("b-");
            int b=Convert.ToInt32(Console.ReadLine());
            int output=(a*a)+(2*a*b)+(b*b);
            Console.WriteLine($"Output: {output}");
        }
    }
}