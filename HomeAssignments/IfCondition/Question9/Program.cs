using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input: ");
        string month=Console.ReadLine();
        string season="";
        if(month=="December"|| month=="January" || month=="February")
        {
            season="winter";
        }
        else if(month=="March" || month=="April" || month=="May")
        {
            season="spring";
        }
        else if(month== "June" || month=="July" || month=="August" )
        {
            season="summer";
        }
        else if(month=="September" || month=="October" || month=="November")
        {
            season="rainfall";
        }
        Console.Write($"output: {season}");
    }
}
