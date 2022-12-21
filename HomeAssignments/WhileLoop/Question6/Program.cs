using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        int i=1;
        Console.WriteLine("Odd No:");
        while(i<=100)
        {
            
            if(i%2!=0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        i=1;
        Console.WriteLine("even No:");
        while(i<=100)
        {
            
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        i=1;
        Console.WriteLine("prime:");
        while(i<=100)
        {
            
            for(int j=2;j<=i/2;j++)
            {
                if(i%j!=0)
                {
                Console.WriteLine(i);
                break;
                }
            }
            i++;
        }
    }
}