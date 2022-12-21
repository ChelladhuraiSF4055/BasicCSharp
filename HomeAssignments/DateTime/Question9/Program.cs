using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a start year ");
        DateTime date1= DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        Console.Write("Enter a end year ");
        DateTime date2= DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        TimeSpan day;
        DateTime year=date1;
        DateTime year1;
        for(int i=0;i<=date2.Year-date1.Year;i++)
        {
            year1=year.AddYears(1);
            day=year1-year;
            if(day.Days==366)
            {
            Console.WriteLine($"{year.Year} is a leap year.");
            Console.WriteLine($"One year form {year.ToShortDateString()} is {year1.ToShortDateString()}");
            }
            year=year1;
        }
    }
}