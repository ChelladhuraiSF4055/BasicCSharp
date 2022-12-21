using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the size of the square matrix(less tham 5): ");
        int n=Convert.ToInt32(Console.ReadLine());
        int [,]array1=new int [n,n];
        int [,]array2=new int [n,n];
        Console.WriteLine("Input elements in the first matrix: ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write($"element- [{i}],[{j}]: ");
                array1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Input elements in the second matrix: ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write($"element- [{i}],[{j}]");
                array2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("The First Matrix is : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write($"{array1[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The Second Matrix is : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write($"{array2[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("The Addition of two matrix is: ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                Console.Write($"{array1[i,j]+array2[i,j]} ");
            }
            Console.WriteLine();
        }

    }
}