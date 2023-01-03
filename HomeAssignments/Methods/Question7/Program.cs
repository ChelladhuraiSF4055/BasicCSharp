using System;
namespace Program;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Input a string:");
        string name=Console.ReadLine();
        Program i=new Program();
        i.Calculate(name);
        
    }
    void Calculate(string name)
    {
        int n=name.Length;
        if(isPalindrome(name,0))
        {
            Console.WriteLine("Its a palindrome");
        }
        else{
            Console.WriteLine("Its not a palindrome");
        }
        /*using loops
        int flag=0;
        for(int i=0;i<n;i++)
        {
            if(name[i]!=name[n-i-1])
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
        */
        //using recursion
        static bool isPalindrome(string s,int i)
        {
            if(i>s.Length/2)
            {
                return true;
            }
            return s[i]==s[s.Length-i-1] && isPalindrome(s,i+1);
        }
    
    }
        
}
 