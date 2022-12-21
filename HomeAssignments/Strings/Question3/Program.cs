using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input the string: ");
        string input=Console.ReadLine();
        input.ToCharArray();
        for(int i=input.Length-1;i>=0;i--)
        {
           Console.Write(input[i]+" "); 
        }
    }
}