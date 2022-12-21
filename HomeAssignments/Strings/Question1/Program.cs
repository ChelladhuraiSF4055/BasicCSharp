using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string input=Console.ReadLine();
        int count=0;
        foreach(var i in input)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}