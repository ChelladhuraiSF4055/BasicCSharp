using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input number of Fibonacci Series: ");
        int n=Convert.ToInt32(Console.ReadLine());
        fib(n);

        void fib(int x)
        {
            int firNo=0;
            int secNo=1;
            int thrNo;
            for(int i=1;i<=x;i++)
            {
                Console.Write($"{firNo} ");
                thrNo =firNo+secNo;
                firNo =secNo;
                secNo=thrNo;
            }
        }
    }
}