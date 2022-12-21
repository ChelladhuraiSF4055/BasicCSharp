using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string input=Console.ReadLine();
        Console.WriteLine("The characters of the string are: ");
        input.ToCharArray();
        foreach(var i in input)
        {
        Console.Write(i+" ");
        }
    }
}