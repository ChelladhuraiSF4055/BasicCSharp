using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of X(base) and(power) Y: ");
        string []arr=Console.ReadLine().Split(' ');
        int X=Convert.ToInt32(arr[0]);
        int Y=Convert.ToInt32(arr[1]);
        int result=1;
        for(int i=1;i<=Y;i++)
        {
            result*=X;
        }
        Console.WriteLine($"The result is: {result}");
    }
}