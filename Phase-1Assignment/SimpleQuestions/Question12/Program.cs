using System;
namespace Question12;
class Program{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=1;i<100;i++)
        {
            if(i%2!=0)
            {
                sum+=i*i;
            }
        }
        Console.WriteLine($"The sum of the square of odd values in Range of 1-99 is: {sum}");
    }
}