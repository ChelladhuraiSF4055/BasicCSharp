using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of line: ");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            for(int space=i;space<=n;space++)
            {
                Console.Write(" ");
            }
            for(int j=1;j<=i*2-1;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}