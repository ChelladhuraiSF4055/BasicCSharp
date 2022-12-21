using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input a username: ");
        string input1=Console.ReadLine();        
        if(input1=="user")
        {
            Console.WriteLine("Username entered");
        }
        else{
            Console.WriteLine("Username wrong");
        }
        Console.WriteLine("Input a password: ");
        string pass=Console.ReadLine();
        if(pass=="pass")
        {
            Console.WriteLine("Password entered successfully!");
        }
        else{
            Console.WriteLine("Password incorrect");
        }

    }
}