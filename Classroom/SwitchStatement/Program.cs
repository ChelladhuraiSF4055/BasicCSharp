using System;
namespace SwitchStatement;
class Program{
    public static void Main(string[] args)
    {
        int result;
        Console.Write("Enter 1st number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd Number: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1.Press '+' for adding two numbers");
        Console.WriteLine("2.Press '-' for subracting two numbers");
        Console.WriteLine("3.Press '*' for multiplating two numbers");
        Console.WriteLine("4.Press '/' for dividing two numbers");
        Console.WriteLine("5.Press '%' for modula dividing two numbers");
        string option=Console.ReadLine();
        switch(option)
        {
            case "+":   
            result= a+b;
            Console.WriteLine($"Result of addition:{result}");
            break;
            case "-":
            result=a-b;
            Console.WriteLine($"Result of subraction: {result}");
            break;
            case "*":
            result=a*b;
            Console.WriteLine($"Result of multiplication: {result}");
            break;
            case "/":
            result=a/b;
            Console.WriteLine($"Result of Division: {result}");
            break;
            case "%":
            result=a%b;
            Console.WriteLine($"Result of modulo division: {result}");
            break;
            default:
            Console.WriteLine("Operation Invalid \nChoose specified operations.");
            break;
        }
    }
}