using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        string answer="yes";
        while(answer=="yes")
        {
        Console.Write("Enter a number: ");
        sum+=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Do You want to continue?");
        answer=Console.ReadLine().ToLower();
        }
        Console.WriteLine($"Sum of given numbers is : {sum}");
        
    }
}