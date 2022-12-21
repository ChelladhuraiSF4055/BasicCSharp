using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input number of terms to display: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int firNum=0;
        int secNum=1;
        int thrNum;
        Console.WriteLine($"Here is the Fibonacci series upto {n} terms: ");
        for(int i=0;i<n;i++)
        {
            thrNum=firNum+secNum;
            Console.Write(firNum+" ");
            firNum=secNum;
            secNum=thrNum;
        }
    }
}