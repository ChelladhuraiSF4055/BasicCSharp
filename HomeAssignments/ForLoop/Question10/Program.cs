using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        int flag=0;
        Console.WriteLine("Input a number: ");
        int n= Convert.ToInt32(Console.ReadLine());
        for(int i=2;i<=n/2;i++)
        {
            if(n%i==0)
            {
                flag=1;
            }
        }
        if(flag==1)
        {
            Console.WriteLine($"{n} is not a prime number.");
        }
        else
        {
            Console.WriteLine($"{n} is a prime number.");
        }
    }
}