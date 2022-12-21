using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        Console.WriteLine($"Today:{today}\n{today.AddDays(40).DayOfWeek}");
    }
}