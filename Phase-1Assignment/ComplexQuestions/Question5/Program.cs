using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        Console.Write("Enter your Date of Birth: ");
        DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        int age=today.Year-dob.Year;
        TimeSpan spec=today-dob;
        Console.Write($"Your age is: {age} and Day you were born was: {dob.DayOfWeek}");
        Console.WriteLine();
        Console.Write($"Age in days, hours, minutes, seconds and milliseconds is: Days:{spec.Days}, Hours: {spec.Hours}, Minutes: {spec.Minutes}, Seconds: {spec.Seconds}, Milliseconds: {spec.Milliseconds}");
    }
}