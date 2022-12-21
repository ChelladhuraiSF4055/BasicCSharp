using System;
namespace Question5{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Physics : ");
            int phy=Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry : ");
            int che=Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths : ");
            int mat=Convert.ToInt32(Console.ReadLine());
            int sum=phy+che+mat;
            float percent=(float)(sum/3);
            if (percent<75)
            {
            Console.WriteLine($"Percentage = {percent}%");
            Console.WriteLine("The candidate is Not eligible for admission");
            }
            else
            {
                Console.WriteLine("The Candidate is eligible for admission.");
            }
        }
    }
}