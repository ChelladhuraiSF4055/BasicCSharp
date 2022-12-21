using System;
namespace Question6{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Price - ");
            float price=float.Parse(Console.ReadLine());
            float total=price+(price*18/100);
            Console.WriteLine($"Total = {total}");
        }
    }
}
