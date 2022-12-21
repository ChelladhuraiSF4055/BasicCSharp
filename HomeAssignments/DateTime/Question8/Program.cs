using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter as a format: M/dd/yyyy");
        DateTime date=DateTime.Parse(Console.ReadLine());
        Console.WriteLine($"{date.AddYears(1)} is later than {date}");
        Console.WriteLine($"{date.AddYears(-1)} is a earlier than {date}");
    }
}