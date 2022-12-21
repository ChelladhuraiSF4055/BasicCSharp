using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter radius: ");
        double radius=double.Parse(Console.ReadLine());
        double area=(double)(22/7)*radius*radius;
        double perimeter=(double)2*3.14*radius;
        Console.WriteLine($"Area: {area} sq.units");
        Console.WriteLine($"Perimeter: {perimeter} units");
    }
}