using System;
namespace ForLoop{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("First Exercise:");
            for (int i=0;i<=25;i++)
            {
                if(i%2==0){
                Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine("Second Exercise: ");
            Console.Write("Enter lower limit: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter upper limit: ");
            int b=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for( int i=a;i<=b;i++){
                sum+=(i*i);
            }
            Console.WriteLine($"The sum of square of numbers in the given limit: {sum}");


        }
    }
}