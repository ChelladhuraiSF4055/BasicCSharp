using System;
namespace Question9;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the rows and Columns of first matrix:");
        string number=(Console.ReadLine());
        string []ar1=(number.Split(' '));
        int n=int.Parse(ar1[0]);
        int m=Convert.ToInt32(ar1[1]);
        int [,]array1=new int[n,m];
        Console.WriteLine("Input the rows and coloums for second matrix:");
        string num=Console.ReadLine();
        string []ar2=num.Split(' ');
        int x=int.Parse(ar2[0]);
        int y=int.Parse(ar2[1]);
        int [,]array2=new int[x,y];
        if(m==x)
        {
        
        //getting two arrays
        Console.WriteLine("Enter the elements of matrix1");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                Console.Write($"element[{i}][{j}]: ");
                array1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter the elements of matrix2");
        for(int i=0;i<x;i++)
        {
            for(int j=0;j<y;j++)
            {
                Console.Write($"element[{i}][{j}]: ");
                array2[i,j]=int.Parse(Console.ReadLine());
            }
        }

        //printing two arrays
        Console.WriteLine("The First Matrix is : ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                Console.Write(array1[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("The Second Matrix is : ");
        for(int c=0;c<x;c++)
        {
            for(int s=0;s<y;s++)
            {
                Console.Write(array2[c,s]);
            }
            Console.WriteLine();
        }

        int [,]res=new int [n,y];

        //Multiplying two matrix
        
        Console.WriteLine("the resultant matrix is: ");
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<y;j++)
            {
                for(int k=0;k<x;k++)
                {
                    res[i,j]+=array1[i,k]*array2[k,j];
                }
            }
        }
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<y;j++)
            {
                Console.Write(res[i,j]+" ");
            }
            Console.WriteLine();
        }
        }
        else
        {
            Console.WriteLine("cant Multiply two strings");
        }
        
    }
}