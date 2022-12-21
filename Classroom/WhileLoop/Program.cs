using System;
namespace WhileLoop;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Exercise1:");
        int i=0;
        while(i<=25)
        {
            Console.WriteLine(i);
            i+=2;
        }
        Console.WriteLine("Exercise2:");
        Console.WriteLine("Enter the number:");
        int number;
        bool temp=false;
        temp=int.TryParse(Console.ReadLine(),out number);
        while(!temp)
        {
            Console.WriteLine("Invalid Input format.\n Please enter the input in number format");
            temp=int.TryParse(Console.ReadLine(), out number);
        }
        Console.WriteLine($"Number is: {number}");
    }
}