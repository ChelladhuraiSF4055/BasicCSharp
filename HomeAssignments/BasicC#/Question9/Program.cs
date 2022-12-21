using System;
namespace Question9{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Input speed: ");
            int speed=Convert.ToInt32(Console.ReadLine());
            Console.Write("Time: ");
            int time=Convert.ToInt32(Console.ReadLine());
            int distance=speed*time*5/18;
            Console.WriteLine($"Output: {distance}");
        }
    }
}