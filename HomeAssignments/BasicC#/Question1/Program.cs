using System;
namespace Question1{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name=Console.ReadLine();
            //concatenation
            Console.WriteLine("Hello: " + name);
            //Placeholder
            Console.WriteLine("Hello: {0}",name);
            //Interpolation
            Console.WriteLine($"Hello:{name}");
        }
    }
}