using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number of terms: ");
        int cube=0;
        int sum=0;
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            cube=i*i*i;
            sum+=cube;
            Console.WriteLine($"Number is : {i} and cube of the {i} is : {cube}");
        }
    }
}