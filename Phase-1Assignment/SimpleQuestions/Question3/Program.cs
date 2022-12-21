using System;
namespace Questioon3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter degree on C: ");
        float celsius=float.Parse(Console.ReadLine());
        double fahrenheit= (double)celsius*(9/5)+32;
        Console.WriteLine(fahrenheit);
    }
}