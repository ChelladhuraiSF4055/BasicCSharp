using System;
namespace DoWhile;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Do you feel hungry?");
        String answer= Console.ReadLine();
        do{
            Console.WriteLine("Eat food");
            Console.WriteLine("Do you still feel hungry?");
            answer = Console.ReadLine();
        }while(answer=="Yes");
    }
}