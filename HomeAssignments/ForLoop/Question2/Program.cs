using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        int sum=0;
        for(int i=1;i<=10;i++)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            sum+=n;
        }
        float avg=(float)sum/10;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
    }
}