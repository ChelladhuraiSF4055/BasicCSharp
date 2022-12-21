using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        bool temp=false;
        int number=0;
        while(temp==false)
        {   
            Console.WriteLine("Input: ");
            temp=int.TryParse(Console.ReadLine(),out number);
            Console.WriteLine("Invalid input enter again");
        }
        Console.WriteLine($"Output: {number} is valid input");
        
    }
}