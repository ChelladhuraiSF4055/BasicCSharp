using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        Console.WriteLine("Display the name of the month of a year: ");
        Console.Write(" ".PadLeft(35,'-'));
        Console.WriteLine();
        DateTime adMon=today;
        
        for(int i=1;i<=12;i++)
        {
            Console.WriteLine(adMon.ToString("MMMM"));
            adMon=adMon.AddMonths(1);
        }
    }
}