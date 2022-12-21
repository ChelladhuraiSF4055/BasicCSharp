using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input a number: ");
        int number=Convert.ToInt32(Console.ReadLine());
        int l=0;
        int sum=0;
        int cube=0;
        for(int copy=number;copy!=0;copy/=10)
        {
        l=copy%10;
        cube=l*l*l;
        sum+=cube;
        }
        if(sum==number)
        {
            Console.WriteLine($"{number} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
}