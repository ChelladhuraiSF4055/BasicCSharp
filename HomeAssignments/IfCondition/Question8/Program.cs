using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        int sugar=Convert.ToInt32(Console.ReadLine());
        if (sugar<90)
        {
            Console.WriteLine("Low sugar");
        }
        else if(sugar>=90 && sugar<130)
        {
            Console.WriteLine("Normal");
        }
        else if(sugar>=130 && sugar<140)
        {
            Console.WriteLine("medium");
        }
        else if(sugar>=140 && sugar<170)
        {
            Console.WriteLine("high sugar - try to reduce it from now");
        }
        else
        {
            Console.WriteLine("You are a very high sugar Patient");
        }
    }
}