using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        string answer;
        do
        {
        Console.WriteLine("Input number: ");
        int no=Convert.ToInt32(Console.ReadLine());
        if(no%2==0)
        {
            Console.WriteLine("Result: Given number is even");
        }
        else 
        {
            Console.WriteLine("Result: Given number is odd");
        }
        Console.WriteLine("Do You want to continue?");
        answer=Console.ReadLine().ToLower();
        }while(answer=="yes");
    }
}