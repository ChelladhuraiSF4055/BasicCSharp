using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        Console.WriteLine("Input the number of elements to be stored in the array: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int []array=new int [n];
        Console.WriteLine($"Input {n} elements in the array:");
        for(int i=0;i<n;i++)
        {
            Console.Write($"element - {i} :");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        foreach(int i in array)
        {
            sum+=i;
        }
        Console.WriteLine($"Sum of all elements stored in the array: {sum}");

    }
}