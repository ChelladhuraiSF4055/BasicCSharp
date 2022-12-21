using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int i=1;
        int sum=0;
        Console.WriteLine("Input Count:");
        int count=Convert.ToInt32(Console.ReadLine());
        Console.Write("number: ");
        while(i<=count)
        {
            sum+=i;
            Console.Write(i);
            i++;
        }
        Console.WriteLine($"\nOutput: {sum}");

    }
}