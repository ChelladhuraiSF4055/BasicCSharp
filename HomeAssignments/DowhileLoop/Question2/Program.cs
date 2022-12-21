using System;
namespace Program;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        int n;
        do
        {
        Console.WriteLine("Enter a number: ");
        n=Convert.ToInt32(Console.ReadLine());
        sum+=n;
        }while(n>=0);
        Console.WriteLine($"The sum is {sum}");
    }
}