using System;
namespace Question4;
class Progam{
    public static void Main(string[] args)
    {
        bool temp;
        int number=0;
        do{
        Console.Write("Input value: ");
        temp=int.TryParse(Console.ReadLine(),out number);
    }while(temp==false);
    Console.WriteLine($"Output: {number}");
    }
}