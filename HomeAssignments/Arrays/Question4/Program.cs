using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the number of elements to be stored in the array: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int []array=new int [n];
        Console.WriteLine($"Input {n} elements in the array:");
        for(int i=0;i<n;i++)
        {
            Console.Write("element -0 : ");
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(array);
        Console.WriteLine($"Minimum element is: {array[0]}");
        Console.WriteLine($"Maximum element is: {array[n-1]}");
    }
}