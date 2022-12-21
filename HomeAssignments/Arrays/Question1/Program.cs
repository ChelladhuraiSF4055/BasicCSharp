using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int []array=new int[10];
        Console.WriteLine("Input 10 elements in the arrary:");
        for(int i=0;i<10;i++)
        {
            Console.Write($"element - {i} :");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Elements in array are: ");
        for(int i=0;i<10;i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}