using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input number of terms to display: ");
        int firNo=0;
        int secNo=1;
        int thrNo;
        int count=1;
        do
        {
            Console.Write(firNo + " ");
            thrNo=firNo+secNo;
            firNo=secNo;
            secNo=thrNo;
            count++;
        }while(count<=10);
    }
}