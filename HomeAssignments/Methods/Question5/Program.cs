using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int flag=0;
        Console.WriteLine("Input a number: ");
        int n =Convert.ToInt32(Console.ReadLine());
        Program i=new Program();
        flag=i.prime(n);
        if(flag==0)
        {
        Console.WriteLine($"{n} is  a prime number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number");
        }
    }
    int  prime(int x)
    {
        for(int i=1;i<=(x/2);i++)
        {
            if(i%2==0)
            {
                return 1;
            }
        }
    return 0;
    }
    
}