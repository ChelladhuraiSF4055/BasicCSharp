using System;
namespace Program;
class Program{
    public static void Main(string[] args)
    {
        int flag=0;
        Console.Write("Input a string:");
        string name=Console.ReadLine();
        int n=name.Length;
        for(int i=0;i<n;i++)
        {
            if(name[i]!=name[n-i])
            {
                flag=1;
            }
        }
        if(flag==0)
        {
            Console.WriteLine("It's a palindrome");
        }
        else
        {
            Console.WriteLine("It's not a palindrome");
        }
    }
        
}
