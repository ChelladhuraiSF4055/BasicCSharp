using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test Data : ");
        int Temp=Convert.ToInt32(Console.ReadLine());
        if(Temp<0)
        {
            Console.WriteLine("Freezing weather");
        }
        else if(Temp>=0 && Temp<=10)
        {
            Console.WriteLine("Very Cold weather");
        }
        else if(Temp>=10 && Temp<=20)
        {
            Console.WriteLine("Cold weather");
        }
        else if (Temp>=20 && Temp<=30)
        {
            Console.WriteLine("Normal");
        }
        else if(Temp>=30 && Temp<=40)
        {
            Console.WriteLine("Its Hot");
        }
        else if(Temp>=30 && Temp<=40)
        {
            Console.WriteLine("Its Very Hot");
        }
        else if(Temp>=40)
        {
            Console.WriteLine("Its Very Hot");
        }
        
    }
}