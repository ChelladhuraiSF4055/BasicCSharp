using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter start: MM/dd/yyyy ");
        DateTime year1=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
        Console.Write("Enter end year: MM/dd/yyyy ");
        DateTime year2=DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
        DateTime year=year1;
        int day;
        for(int i=0;i<=year2.Year-year1.Year;i++)
        {
            day=year.DayOfYear;
            if(day==366)
            {
                Console.WriteLine($"{year.ToShortDateString()} day: {day} of {year.Year} (Leap Year)");

            }
            Console.WriteLine($"{year.ToShortDateString()} day: {day} of {year.Year}");
            year=year.AddYears(1);
        }
    }
}