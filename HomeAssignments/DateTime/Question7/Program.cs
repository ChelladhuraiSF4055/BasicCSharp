using System;
namespace Questin7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter date as MM/dd/yyyy hh:mm:ss tt");
        DateTime date1=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter date as MM/dd/yyyy hh:mm:ss tt");
        DateTime date2=DateTime.Parse(Console.ReadLine());
        if(date1<date2)
        {
            Console.WriteLine($"{date1} is earlier than {date2}");
        }
        else
        {
            Console.WriteLine($"{date2} is earlier than {date1}");
        }
    }
}