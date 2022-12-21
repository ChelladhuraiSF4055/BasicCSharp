using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter starting year: ");
        DateTime year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        Console.Write("Enter the value of N: ");
        DateTime N=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        DateTime i=year;
        while(i.Year<=N.Year)
        {
            
            if(i.Year%4==0)
            {
                if(i.Year%100!=0)
                {
                    Console.Write(i.Year+" ");
                }
                else if(i.Year%400==0)
                {
                    Console.Write(i.Year+" ");
                }
            }
            i=i.AddYears(1);
            
        }
    }
}