using System;
namespace WhilePractise;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Do yoy feel Hungry?");
        string answer=Console.ReadLine();
        while(answer!="No")
        {
            Console.WriteLine("Eat food");
            Console.WriteLine("Do you still feel Hungry?");
            answer=Console.ReadLine();
        }
    }
}