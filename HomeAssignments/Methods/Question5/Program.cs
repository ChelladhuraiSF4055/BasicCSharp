using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int flag=0;
        Console.WriteLine("Input a number: ");
        int n =Convert.ToInt32(Console.ReadLine());
        prime(n);

        void prime(int x)
        {
            for(int i=1;i<=(x/2);i++)
            {
                if(i%2==0)
                {
                    flag=1;
                }
            }
        if(flag==1)
        {
        Console.WriteLine($"{x} is  a prime number.");
        }
        else
        {
            Console.WriteLine($"{x} is not a prime number");
        }
        }
    }
}