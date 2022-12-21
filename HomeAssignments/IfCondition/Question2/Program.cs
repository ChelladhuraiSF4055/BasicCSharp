using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Test Data : ");
        int age= Convert.ToInt32(Console.ReadLine());
        if (age>18)
        {
            Console.WriteLine("Congratulation!\nYou are eligible for casting your vote.");
        }
        else{
            Console.WriteLine("You aren't eligible for casting vote.");
        }
    }
}