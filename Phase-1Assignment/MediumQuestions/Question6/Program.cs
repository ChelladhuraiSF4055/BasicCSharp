using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        //reading elements
        int [,] arr1=new int [3,3];
        int [,] arr2=new int [3,3];
        Console.WriteLine("Input the elements of first matrix: ");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write($"element - [{i}],[{j}]");
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Input the elements of second matrix: ");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write($"element - [{i}],[{j}]");
                arr2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        //Adding
        int [,]res=new int [3,3];
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                res[i,j]=arr1[i,j]+arr2[i,j];
            }
        }
        //printing
        Console.WriteLine("The First matrix is: ");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The Second matrix is: ");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The Addition of two matrix is: ");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}