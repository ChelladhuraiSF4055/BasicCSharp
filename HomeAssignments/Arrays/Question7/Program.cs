using System;
namespace Question7;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter row:");    
       int n=Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Enter Column");
       int m=Convert.ToInt32(Console.ReadLine());
       int [,]array=new int[n,m];
       for(int i=0;i<n;i++)
       {
           for(int j=0;j<m;j++)
           {
               Console.Write($"element - {i},{j}: ");
               array[i,j]=Convert.ToInt32(Console.ReadLine());
           }
       }
       Console.WriteLine("The matrix is:");
       for(int i=0;i<n;i++)
       {
           for(int j=0;j<m;j++)
           {
           Console.Write(array[i,j]);
           }
           Console.WriteLine();
       }


    }
}