using System;
namespace SwitchPractise;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your choice:");
        string option=Console.ReadLine().ToLower();
        switch(option)
        {
            case "tea":
            {
                Console.WriteLine("tea Selected");
                break;
            }
            case "coffee":
            {
                Console.WriteLine("Coffee selected");
                break;
            }
            default:
            {
                Console.WriteLine("Water");
                break;
            }
        }
    }
}