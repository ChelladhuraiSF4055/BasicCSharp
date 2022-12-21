using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        Console.WriteLine($"Yesteday: {today.AddDays(-1).ToShortDateString()}");
        Console.WriteLine($"Tomorrow: {today.AddDays(1).ToShortDateString()}");
    }
}