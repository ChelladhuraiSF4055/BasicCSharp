using System;
namespace DateTimeAssinment;
class Program{
    public static void Main(string[] args)
    {
        //Exercise 1
        DateTime today=new(2021, 8,10,10,40,32);
        Console.WriteLine($"Year: {today.Year}");
        Console.WriteLine($"Month: {today.Month}");
        Console.WriteLine($"Day: {today.Day}");
        Console.WriteLine($"Hour: {today.Hour}");
        Console.WriteLine($"Minute: {today.Minute}");
        Console.WriteLine($"Second: {today.Second}");
        //Exercise 2
        Console.WriteLine();
        string to=today.ToString(@"yyyy/M/dd hh:mm:ss tt");
        string []arr=to.Split('/',':',' ');
        Console.WriteLine("Output: ");
        for(int i=arr.Length-1;i>=0;i--)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
        //Exercise3
        DateTime dob=new DateTime();
        Console.WriteLine("Enter as  yyyy/MM/dd hh:mm:ss tt");
        bool value=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt", null,
        System.Globalization.DateTimeStyles.None,out dob);
        while(!value)
        {
            Console.WriteLine("Invalid input re enter data in yyyy/MM/dd hh:mm:ss format:");
            value=DateTime.TryParseExact(Console.ReadLine(), "yyyy/MM/dd hh:mm:ss tt", null, 
            System.Globalization.DateTimeStyles.None, out dob);
        }
        Console.WriteLine($"Year: {dob.Year}");
        Console.WriteLine($"Month: {dob.Month}");
        Console.WriteLine($"day: {dob.Day}");
    }

}