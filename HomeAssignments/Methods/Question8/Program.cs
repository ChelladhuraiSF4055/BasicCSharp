using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        GetMark();
    }
    public static void  GetMark()
    {
        Console.WriteLine("Mark1:");
        int mark1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mark2:");
        int mark2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mark3:");
        int mark3=Convert.ToInt32(Console.ReadLine());
        percent(mark1,mark2,mark3);
    }

    static void percent(int m1,int m2,int m3)
    {
        int sum=m1+m2+m3;
        int per=sum/3;
        Console.WriteLine($"Mark1: {m1}\nMark2: {m2}\nMark3: {m3}\n");
        Console.WriteLine($"Percentage: {per}");
    }

}