using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input: ");
        DateTime dob2 = new DateTime();
        Console.WriteLine(" Enter your date of birth dd/MM/yyyy hh:mm:ss tt format");        dob2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);
        Console.WriteLine(dob2.ToString("dd/MM/yyyy"));
        Console.WriteLine($"Complete date: {dob2}");
        Console.WriteLine($"Short Date {dob2.ToShortDateString()}");
        Console.WriteLine($"{dob2.ToLongDateString()}");
        Console.WriteLine($"{dob2.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        Console.WriteLine(dob2.ToString("dd/MM/yyyy"));
        Console.WriteLine(dob2.ToShortTimeString());
    }
}