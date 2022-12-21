using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Inputs the speed: ");
        float speed=float.Parse(Console.ReadLine());
        if(speed<=10)
        {
            Console.WriteLine("Slow");
        }
        else if(speed>10 && speed <=50)
        {
            Console.WriteLine("average");
        }
        else if(speed>50 && speed <=150)
        {
            Console.WriteLine("fast");
        }
        else if(speed>150 && speed<=1000)
        {
            Console.WriteLine("ultra fast");
        }
    }
}