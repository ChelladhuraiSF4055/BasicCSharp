using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter month in name:");
        DateTime month=DateTime.ParseExact(Console.ReadLine(),"MMMM",null);
        Console.WriteLine("Enter number of leaves: ");
        int leave=int.Parse(Console.ReadLine());
        int totDay=DateTime.DaysInMonth(DateTime.Now.Year,month.Month);
        int salary=(totDay-leave)*500;
        Console.WriteLine(salary);

    }
}