using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input1: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input2: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Addition: {add(a,b)}");
        Console.WriteLine($"Subraction: {Sub(a,b)}");
        Console.WriteLine($"Multiplication: {mul(a,b)}");
        Console.WriteLine($"Division: {Div(a,b)}");
        int add(int x,int y)
        {
            return x+y;
        }
        int Sub(int x, int y)
        {
            return x-y;
        }
        int mul(int x, int y)
        {
            return x*y;
        }
        float Div(int x, int y)
        {
            return (float)a/b;
        }
    }   
}