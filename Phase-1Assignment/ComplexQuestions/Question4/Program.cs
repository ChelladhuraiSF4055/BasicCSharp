using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string name=Console.ReadLine();
        string test="";
        foreach(var i in name)
        {
            if(!(test.Contains(i)))
            {
                test+=i;
            }
        }
        Console.Write($"Output: {test}");
    }
}