using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of line: ");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=n*3;j++)
            {   
                if(j==1||i==1||j==n*3||i==n)
                {
                Console.Write("*");
                }
                else{
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}