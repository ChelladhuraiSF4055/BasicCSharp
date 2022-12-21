using System;
namespace Question14;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year: ");
        DateTime year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        Console.Write("Enter a Month: ");
        DateTime month= DateTime.ParseExact(Console.ReadLine(),"MM",null);
        Console.Write("Enter number of leaves taken: ");
        int leave=int.Parse(Console.ReadLine());
        int days=DateTime.DaysInMonth(year.Year,month.Month);
        int workDay=days-leave;
        int salary=workDay*500;
        Console.WriteLine($"Salary Rs. {salary}");
        
    }
}