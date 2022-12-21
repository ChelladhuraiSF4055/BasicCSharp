using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter as format: dd/MM/yyyy");
        DateTime date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.WriteLine($"The day of the week for{date} is  {date.DayOfWeek}.");
    }
}