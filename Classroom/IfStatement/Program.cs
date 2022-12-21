using System;
namespace IfStatement;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter mark: ");
        int mark=Convert.ToInt32(Console.ReadLine());
        if (mark>80)
        {
            Console.WriteLine("Grade A");
        }
        else if(mark>60 && mark<80)
        {
            Console.WriteLine("Grade B");
        }
        else if(mark>35 && mark<60)
        {
            Console.WriteLine("GradeC");
        }
        else if(mark<35 && mark>=0)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}