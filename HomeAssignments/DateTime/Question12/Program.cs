using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        DateTime month;
        Console.Write("Input the Month NO. as MM  ");
        month=DateTime.ParseExact(Console.ReadLine(),"MM", null);
        Console.Write("Input the year as yyyy: ");
        DateTime year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        Console.WriteLine($"The Number of days in month of {month.ToString("MMMM")} is:");
        int days= DateTime.DaysInMonth(year.Year,month.Month);
        Console.WriteLine(days);
    }
}