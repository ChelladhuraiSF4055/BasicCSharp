using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
      Console.WriteLine("Input the Day dd: ");
      DateTime day=DateTime.ParseExact(Console.ReadLine(),"dd",null);
      Console.WriteLine("Input the Month as MM: ");
      DateTime month=DateTime.ParseExact(Console.ReadLine(),"MM",null);
      Console.WriteLine("Input the year as yyyy:");
      DateTime year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
      DateTime i=new DateTime(year.Year,month.Month,day.Day);
      while(i.DayOfWeek is )
      {
      (i.AddDays(7-));
      }
    }
}