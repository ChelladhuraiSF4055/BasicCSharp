using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter required: ");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=i;j++)
            {
            Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}