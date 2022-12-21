using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter value: ");
        int val=int.Parse(Console.ReadLine());
        double sum=0;
        for(int j=0;j<val;j++)
        {
            sum+=Math.Pow(2,j)/Factorial(j);
        }
        Console.Write("Series value is "+(double)Math.Round(sum,4));
        double Factorial(int a)
        {
            if(a==0)
            {
                return 1;
            }
            else 
            {
                return a*Factorial(a-1);
            }
        }
    }
}