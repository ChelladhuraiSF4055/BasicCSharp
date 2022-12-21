using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Original string of numbers: ");
        string[] input1=Console.ReadLine().Split(' ');
        int [] arr=new int[(input1.Length)];
        for(int i=0;i<input1.Length;i++)
        {
            arr[i]=Convert.ToInt32(input1[i]);
        }
        
        int max=arr[0];
        int min=arr[0];
        foreach(int i in arr)
        {
            if(i>max)
            {
                max=i;
            }
            if(i<min)
            {
                min=i;
            }
        }
        Console.WriteLine($"Maximum and minimum of string: {max} and {min}");
    }  
}