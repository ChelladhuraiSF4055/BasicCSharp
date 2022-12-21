using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        
        string answer;
        do{
            Console.WriteLine("Enter a number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("You have provided an even number");
            }
            else
            {
                Console.WriteLine("You have provided an odd number");
            }
            Console.WriteLine("Do You want to find another one?");
            answer=Console.ReadLine().ToLower();
            while(answer!="yes" && answer!="no")
            {
                Console.WriteLine("Invalid Input, Choose Yes or No");
                answer=Console.ReadLine();
            }
        }while(answer=="yes");

    }
}
