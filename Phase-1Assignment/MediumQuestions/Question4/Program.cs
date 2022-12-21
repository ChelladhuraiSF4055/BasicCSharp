using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input a limit: ");
        string number=Console.ReadLine();
        int n=Convert.ToInt32(number);
        int rem;
        double p;
        int sum;
        Console.WriteLine($"Armstrong number between 1 to 1000 are: ");
        for(int i=1;i<=n;i++)
        {
            p=1;
            sum=0;
            int j=i;
            string count=i.ToString();
            while(j!=0)
            {
            rem=j%10;
            int c=count.Length;
            p=Math.Pow(rem,c);
            sum+=(int)p;
            j/=10;
            }
        if(sum==i)
        {
            Console.Write(i+ " ");
        }
        }
    }
}