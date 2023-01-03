using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter another number: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Program i =new Program();
        i.swap(ref a,ref b);
    }
    void swap(ref int x, ref int y)
    {
        int temp=x;
        x=y;
        y=temp; 
    Console.WriteLine($"Now the 1st Number is: {x} and 2nd Number is:  {y}");
    }
}