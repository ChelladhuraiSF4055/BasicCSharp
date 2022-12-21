using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the string: ");
        string input1=Console.ReadLine();
        Console.WriteLine("Input the position to start extraction: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the length of substring: ");
        int li=Convert.ToInt32(Console.ReadLine());
        string sub=input1.Substring(n,li);
        Console.WriteLine($"The substring retrieve from the string is: {sub}");
    }
}