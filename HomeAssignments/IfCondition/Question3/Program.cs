using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Test Data : ");
        int year=Convert.ToInt32(Console.ReadLine());
        if(year%400==0 )
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else if(year%100==0)
        {
            Console.WriteLine($"{year} is not leap year");
        }
        else if(year%4==0)
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else 
        {
            Console.WriteLine($"{year} is not leap year");
        }
    }
    }