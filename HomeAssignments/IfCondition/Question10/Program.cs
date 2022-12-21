using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input: ");
        string password=Console.ReadLine();
        if(password=="HiTeam")
        {
            Console.WriteLine("Output: Right password");
        }
        else
        {
            Console.WriteLine("Ouput: Wrong password");
        }
    }
}