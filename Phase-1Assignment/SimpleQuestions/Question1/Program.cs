using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number In inches: ");
        float convertToCM=float.Parse(Console.ReadLine());
        double inCM=(double) convertToCM * 2.54;
        Console.WriteLine($"The equivalent value in ConsoleModifiers is: {inCM} cm.");
    }
}