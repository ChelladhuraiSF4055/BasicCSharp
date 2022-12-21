using System;
namespace Methods;
class Program{
    public static void Main(string[] args)
    {
        string answer;
        do
        {
        Console.WriteLine("Enter 1st number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd number: ");
        int b=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Which operation would u like to perform:");
        Console.WriteLine("1.Addition\n2.Subraction\n3.Multiplication\n4.Division");
        int choice=Convert.ToInt32(Console.ReadLine());
        float result=0;
        switch(choice)
        {
            case 1: result=addition(a,b);
            break;
            case 2: result=subraction(a,b);
            break;
            case 3: result=multiplication(a,b);
            break;
            case 4: result=division(a,b);
            break;
        }
        Console.WriteLine($"Result is {result}");
        Console.WriteLine("DO U Want to continue?");
        answer=Console.ReadLine().ToLower();
        }while(answer=="yes");

        int addition(int n1,int n2)
        {
            return n1+n2;
        }
        int subraction(int n1,int n2)
        {
            return n1-n2;
        }
        int multiplication(int n1,int n2)
        {
            return n1*n2;
        }
        float division(int n1,int n2)
        {
            return (float)n1/n2;
        }
    }
}