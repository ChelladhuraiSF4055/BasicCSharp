using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the rows and columns of first matrix: ");
        string [] rAc=Console.ReadLine().Split(' ');
        int row1=Convert.ToInt32(rAc[0]);
        int col1=Convert.ToInt32(rAc[1]);
        Console.WriteLine("Enter the rows and columns of second matrix:");
        string [] rAc2=Console.ReadLine().Split(' ');
        int row2=Convert.ToInt32(rAc2[0]);
        int col2=Convert.ToInt32(rAc2[1]);
        int [,]arr1=new int [row1,col1];
        int [,]arr2=new int [row2,col2];
        //reading
        Console.WriteLine("Enter the element of First matrix: ");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<col1;j++)
            {
                Console.WriteLine($"element [{i}][{j}]");
                arr1[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("Enter the element of second matrix: ");
        for(int i=0;i<row2;i++)
        {
            for(int j=0;j<col2;j++)
            {
                Console.WriteLine($"element [{i}][{j}]");
                arr2[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }
        //multiply for(int i=0;i<row1;i++)
        int sum=0;
        int [,]res=new int [row1,col2];
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<col2;j++)
            {
                sum=0;
                for(int k=0;k<col1;k++)
                {
                    sum+=arr1[i,k]*arr2[k,j];
                }
                res[i,j]=sum;
            }
        }
        //printing
        Console.WriteLine("The resultant matrix: ");
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<col2;j++)
            {
                Console.Write(res[i,j]+" ");
            }
        Console.WriteLine();
        }

    }
}