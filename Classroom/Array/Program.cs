using System;
namespace Array;
class Program{
    public static void Main(string[] args)
    {
        int flag=0;
        string [] names=new string[5];
        Console.WriteLine("Enter 5 elements of array:");
        for(int i=0;i<5;i++)
        {
            names[i]=Console.ReadLine();
        }
        Console.WriteLine("Enter the name to be searched:");
        string search=Console.ReadLine();
        //forLoop
        for(int i=0;i<5;i++)
        {
            if(search==names[i])
            {
                flag=1;
                Console.WriteLine($"The name is present in array at {i}");
            }
        }
        if (flag!=1) 
        {
            Console.WriteLine($"The name is not present in array");
        }
        //Foreach
       foreach(string i in names)
       {
           if(search==i)
            {
                flag=1;
                Console.WriteLine($"The name is present in array");
            }
       }
       if (flag!=1) 
        {
            Console.WriteLine($"The name is not present in array");
        }
    }
}