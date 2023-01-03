using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.Write($"The factorial of {n}! is :");
        Console.WriteLine(fact(n));
    }
        static int fact(int x)
        {
            int mul=1;
            while(x!=0)
            {
                mul*=x;
                x--;
            }
            return mul;
        }
    
}