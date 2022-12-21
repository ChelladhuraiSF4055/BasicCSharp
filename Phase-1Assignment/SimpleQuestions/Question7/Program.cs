using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inputs a integer: ");
        int number=Convert.ToInt32(Console.ReadLine());
        if(number<100)
        {
            Console.WriteLine("Less than 100");
        }
        else if(number>=100 && number<=200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else if(number>200)
        {
            Console.WriteLine("Greater than 200");
        }
    }
}