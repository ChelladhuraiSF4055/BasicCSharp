using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        int count=1;
        Console.WriteLine("Enter required Line");
        int n= Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++)
        {
            for(int space=i;space<=n;space++)
            {
                Console.Write(" ");
            }
            for(int j=1;j<=i;j++)
            {
                Console.Write($"{count} ");
                count++;
            }
            Console.WriteLine();
        }
    }
}