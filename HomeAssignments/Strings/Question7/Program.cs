using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the string: ");
        string wel=Console.ReadLine().ToLower();
        int vowCount=0;
        int conCount=0;
        foreach(int i in wel)
        {
            if(i == 'a' || i=='e' || i=='o' || i=='u'|| i=='i')
            {
                vowCount++;
            }
            else
            {
                conCount++;
            }
        }
        Console.WriteLine($"The total number of vowel in the string: {vowCount}");
        Console.WriteLine($"The total number of consonant in the string: {conCount}");
    }
}