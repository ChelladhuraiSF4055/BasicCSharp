using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        int flag=0;
        Console.WriteLine("Input the 1sr string: ");
        string input1=Console.ReadLine();
        Console.WriteLine("Input the 2nd string: ");
        string input2=Console.ReadLine();
        int count1=0;
        int count2=0;
        foreach(var i in input1)
        {
            count1++;
        }
        foreach(var i in input2)
        {
            count2++;
        }
        if(count1==count2)
        {
            int i=0;
            while(i<count1)
            {
                if(input1[i]!=input2[i])
                {
                    flag=1;
                }
                i++;
            }
        
            if(flag==0)
            {
                Console.WriteLine("The length of both strings are equal and also, both strings are equal");
            }
            else
            {
                Console.WriteLine("The length is same but they are different strings ");

            }
        }
        else
        {
            Console.WriteLine("The two strings are different.");
        }
    }
}