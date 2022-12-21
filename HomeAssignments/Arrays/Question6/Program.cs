using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the size of array: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int []array=new int[n];
        Console.WriteLine($"Input {n} elements in the array:");
        for(int i=0;i<n;i++)
        {
            Console.Write($"element- {i} : ");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(array);
        Console.WriteLine("Elements of array in sorted ascending order:");
        foreach(int i in array)
        {
            Console.Write($"{i} ");
        }
    }
}