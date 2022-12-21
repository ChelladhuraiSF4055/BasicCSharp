using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        DateTime dob=new DateTime();
        Console.WriteLine("Enter as dd/MM/yyyy h:mm:ss tt format:");
        dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy h:mm:ss tt", null);
        Console.WriteLine($"Year = {dob.Year}");
        Console.WriteLine($"month = {dob.Month}");
        Console.WriteLine($"day = {dob.Day}");
        Console.WriteLine($"hour = {dob.Hour}");
        Console.WriteLine($"minute = {dob.Minute}");
        Console.WriteLine($"second = {dob.Second}");
        Console.WriteLine($"millisecond = {dob.Millisecond}");
    }
}