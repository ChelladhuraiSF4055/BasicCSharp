using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter password: ");
        string passCheck=Console.ReadLine();
        string pass="s3cr3t!P@ssw0rd";
        if(passCheck==pass)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
        
    }
}