using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the number of elements to store in the array: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int []array=new int [n];
        Console.WriteLine($"Input {n} number of elements in the array:");
        for(int i=0;i<n;i++)
        {
            Console.Write($"element - {i} : ");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The values store into the array are: ");
        
        foreach(int value in array)
        {
            Console.Write($"{value} ");
        }
        Console.WriteLine("The values stored in array in reverse order: ");
        for(int i=n-1;i>=0;i--)
        {
            Console.Write($"{array[i]} ");
        }
    }
}