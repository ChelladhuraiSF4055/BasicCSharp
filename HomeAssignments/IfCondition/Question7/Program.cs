using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test Data : ");
        Console.Write("Enter id: ");
        int id=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Your Name:");
        string name=Console.ReadLine();
        Console.Write("Unit Consumed:");
        int unit=Convert.ToInt32(Console.ReadLine());
        double perUnit=0;
        Console.WriteLine($"Customer IDNO : {id}");
        Console.WriteLine($"Customer Name: {name}");
        Console.WriteLine($"unit Consumed: {unit}");
     for(int i=1;i<=unit;i++)
     {
          if(i<0 && i>=199)
          {
               perUnit+=0;
          }
        if(i<=200)
        {
             perUnit+=1.20f;
        }
        else if(i>=200 && i<400)
        {
             perUnit+=1.50f;
        }
        else if(i>=400 &&  i<600)
        {
             perUnit+=1.80f;
        }
        else
        {
             perUnit+=2.00f;
        }
        
        
     }
        Console.WriteLine($"Amount Charges @Rs. {Math.Round(perUnit,2)}");
        double surcharge=0;
        if(perUnit>400)
        {
             surcharge=(double)15*perUnit/100;
        }
        Console.WriteLine($"Surcharge Amount: {surcharge}");
        double total=surcharge+perUnit;
        Console.WriteLine($"Net amount paid by customer:{total}");
    }
}