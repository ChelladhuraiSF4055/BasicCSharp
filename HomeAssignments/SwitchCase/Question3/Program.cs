using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int days=0;
        Console.WriteLine("Test Data: ");
        int month=Convert.ToInt32(Console.ReadLine());
        switch(month)
        {
            case 1: days=31;
            break;
            case 2: days=29;
            break;
            case 3:days=31;
            break;
            case 4: days=30;
            break;
            case 5: days=31;
            break;
            case 6:days=30;
            break;
            case 7: days=31;
            break;
            case 8: days=31;
            break;
            case 9: days=30;
            break;
            case 10: days=31;
            break;
            case 11: days=30;
            break;
            case 12:days=31;
            break;
        }
        Console.WriteLine($"Month have {days} days");
    }
}