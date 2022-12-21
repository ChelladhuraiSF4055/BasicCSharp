using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the string: ");
        int digit=0;
        int alpha=0;
        int els=0;
        string input1=Console.ReadLine();
        foreach(char i in input1)
        {
            if(i>='1' && i<='9')
            {
                digit++;
            }
            else if(i<='a' && i>='z')
            {
                alpha++;
            }
            else
            {
                els++;
            }
        }
        Console.WriteLine($"Number of Alphabets in the string is: {input1}");
        Console.WriteLine($"Number of Digits in the string: {alpha}");
        Console.WriteLine($"Number of Special characters in the string is: {els}");
    }
}