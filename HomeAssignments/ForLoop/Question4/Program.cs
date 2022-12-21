using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the number (Table to be calculated: ");
        int number=Convert.ToInt32(Console.ReadLine());
        int mul;
        for(int i=1;i<=10;i++)
        {
            mul=number*i;
            Console.WriteLine($"{number} X {i} = {mul}");
        }
    }
}