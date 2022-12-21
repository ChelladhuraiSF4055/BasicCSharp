using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input a string: ");
        string input1=Console.ReadLine();
        Console.WriteLine("Input the substring to search: ");
        string test= Console.ReadLine();
        if(input1.Contains(test))
        {
            Console.WriteLine("The substring exists in the string");
        }
        else{
            Console.WriteLine("The substring doesn't exist in the string");
        }
    }
}