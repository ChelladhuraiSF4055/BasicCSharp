using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the no of elements:");
        int n=Convert.ToInt32(Console.ReadLine());
        int []array=new int [n];
        Console.WriteLine($"Input the number of elements to be stored in the array: {n}");
        Console.WriteLine($"Input {n} elements in the array:");
        for(int i=0;i<n;i++)
        {
            Console.Write($"element -{i} : ");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The Even elements are: ");
        foreach(int i in array)
        {
            if(i%2==0)
            {
            Console.Write($"{i} ");
            }
        }
        Console.WriteLine("\nThe odd elements are: ");
        foreach(int i in array)
        {
            if(i%2!=0)
            {
            Console.Write($"{i} ");
            }
        }

    }
}