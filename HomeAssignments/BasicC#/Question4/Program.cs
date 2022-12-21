using System;
namespace Question4{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Input radius =");
            float radius=float.Parse(Console.ReadLine());
            Console.Write("Height =");
            float height=float.Parse(Console.ReadLine());
            double Volume= (3.14)*(radius*radius)*height;
            Console.Write($"Volume : {Volume}");
        }
    }
}