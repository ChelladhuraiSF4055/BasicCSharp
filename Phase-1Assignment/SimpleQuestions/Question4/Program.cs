using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter in rupees: ");
        int inr=Convert.ToInt32(Console.ReadLine());
        double usd=(double)1.22/inr*100;
        double eur=(double)1.27/inr*100;
        double cny=(double)8.79/inr*100;
        Console.WriteLine($"Eqivalent currency values are:\nUSD: {usd} \nEUR: {eur}\nCNY: {cny}");
    }
}