using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Starting number: ");
        int n1=Convert.ToInt32(Console.ReadLine());
        Console.Write("difference: ");
        int d=Convert.ToInt32(Console.ReadLine());
        Console.Write("number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int j=n1;
        int sum=0;
        for(int i=1;i<=n;i++)
        {
            sum+=j;
            Console.Write(j+" ");
            j+=2;
        }
        Console.WriteLine();
        Console.WriteLine($"Sum is: {sum}");
    }
}