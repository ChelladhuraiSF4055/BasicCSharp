using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        
        Console.WriteLine("Input number of terms : ");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n*2;i+=2)
        {
            sum+=i;
            Console.Write(i+" ");
        }
        Console.WriteLine($"\nThe Sum of odd Natural Number upto {n} terms: {sum}");

    }
}