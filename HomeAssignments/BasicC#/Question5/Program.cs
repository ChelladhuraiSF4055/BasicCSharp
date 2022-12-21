using System;
namespace Question5{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Physics- ");
            int phy=Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry - ");
            int che=Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths - ");
            int mat=Convert.ToInt32(Console.ReadLine());
            int sum=phy+che+mat;
            Console.WriteLine($"Sum = {sum}");
            double percent=(double)(sum/3);
            Console.WriteLine($"Percentage = {percent}%");
        }
    }
}