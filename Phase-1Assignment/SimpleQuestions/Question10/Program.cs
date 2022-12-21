using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a char: ");
        char isVowel=char.Parse(Console.ReadLine());
        if(isVowel=='a' || isVowel=='e' || isVowel=='i' || isVowel=='o' || isVowel=='u')
        {
            Console.WriteLine("Its a vowel");
        }
        else
        {
            Console.WriteLine("Its not a vowel");
        }
    }
}