using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int mul=n;;
        for(int i=1;i<=20;i++)
        {
            mul=n*i;
            Console.WriteLine($"{n} X {i} = {mul}");

        }
    }
}