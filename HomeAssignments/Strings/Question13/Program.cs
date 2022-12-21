using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        int number;
        int sum=0;
        bool temp;
        Console.Write("Input:");
        string s=Console.ReadLine();
        string[] inp = s.Split(' ');
        for(int i=0;i<inp.Length;i++)
        {
            if(temp=int.TryParse(inp[i], out number))
            {
                sum+=number;
            }
        }
        Console.WriteLine($"Output: {sum}");
    }
}