using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test Data : ");
        Console.WriteLine("Input the 1st number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the 2nd number: ");
        int b= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the 3rd number: ");
        int c= Convert.ToInt32(Console.ReadLine());
        if (a>b && a>c)
        {
            Console.WriteLine("The 1st Number is the greatest among three");
        }
        else if(b>a && b>c)
        {
            Console.WriteLine("The 2nd Number is the greatest among three");
        }
        else
        {
            Console.WriteLine("The 3rd Number is the greatest among three");
        }
    }
}