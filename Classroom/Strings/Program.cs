using System;
namespace Strings;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Main String: ");
        string input=Console.ReadLine();
        Console.Write("String to be searched: ");
        string search=Console.ReadLine();
        string []array=input.Split(search);
        Console.WriteLine($"String searched count: {array.Length-1}");
    }
}