using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first Integer: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second Integer: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Here are the options : ");
        Console.WriteLine("1-Addition");
        Console.WriteLine("2-Subraction");
        Console.WriteLine("3-Multiplication");
        Console.WriteLine("4-Division");
        Console.WriteLine("5-Exit");
        Console.Write("Input your choice: ");
        int choice=Convert.ToInt32(Console.ReadLine());
        int result=0;
        switch(choice)
        {
            
            case 1: result=a+b;
            Console.WriteLine($"The Addition of {a} and {b} ");
            break;
            case 2: result=a-b;
            Console.WriteLine($"The Subraction of {a} and {b} ");
            break;
            case 3: result=a*b;
            Console.WriteLine($"The Multiplication of {a} and {b} ");
            break;
            case 4: result =a/b;
            Console.WriteLine($"The Division of {a} and {b} ");
            break;
            case 5: break;
        }
        Console.WriteLine($"Output is : {result}");
        
    }
}
