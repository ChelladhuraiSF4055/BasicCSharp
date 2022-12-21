using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input number of terms to display: ");
        int count=Convert.ToInt32(Console.ReadLine());
        int firNo=0;
        int secNo=1;
        int i=1;
        int thrNo;
        while(i<=count)
        {
            Console.Write(firNo + " ");
            
            thrNo=firNo+secNo;
            firNo=secNo;
            secNo=thrNo;
            i++;
            
        }
    }
}