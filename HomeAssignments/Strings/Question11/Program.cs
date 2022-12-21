using System;
namespace Question11;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Original String: ");
        string org=Console.ReadLine();
        string distinct="";
        for(int i=0;i<org.Length;i++)
        {
            if(!(distinct.Contains(org[i])))
            {
                distinct+=org[i];
            }
        }
        Console.WriteLine($"Original String: {org}");
        Console.WriteLine($"After removing duplicates from the said string {distinct}");        
    }
}