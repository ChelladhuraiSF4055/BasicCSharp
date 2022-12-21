using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Array of Date Time: ");
        DateTime[] dates = { DateTime.Now, 
        new DateTime(2016, 8, 16, 9, 28, 0),
        new DateTime(2011, 5, 28, 10, 35, 0),
        new DateTime(1979, 12, 25, 14, 30, 0) };
        for(int i=0;i<dates.Length;i++)
        {
        Console.WriteLine($"Day: {dates[i]. ToString($"M/dd/yyyy hh:mm:ss")}");
        Console.WriteLine($"Day: {dates[i].ToString().Substring(0,10)} Time: {dates[i].ToString().Substring(13,17)}");
        }
        
    }
}