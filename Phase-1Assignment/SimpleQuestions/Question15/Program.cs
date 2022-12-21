using System;
namespace Question15;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int flag=0;
        for(int i=2;i<n;i++)
        {
            if(n%i!=0)
            {
                flag=1;
            }
        }
        if(flag==1)
        {
            Console.WriteLine("Its a prime number");
        }
        else 
        {
            Console.WriteLine("Its not a prime number");
        }
    }
}