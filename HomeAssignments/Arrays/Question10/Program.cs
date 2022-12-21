using System;
namespace Question10;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the rows and columns of the matrix: ");
        String[]  arr=Console.ReadLine().Split(' ');
        int row=Convert.ToInt32(arr[0]);
        int col=Convert.ToInt32(arr[1]);
        int [,]mat=new int[row,col];
        Console.WriteLine("Input the elements of first matrix:");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                Console.Write($"element-[{i}][{j}]");
                mat[i,j]=int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("The matrix is:");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                Console.Write(mat[i,j]+" ");
            }
            Console.WriteLine();
        }
        int [,]cop=new int [col,row];

        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                cop[j,i]=mat[i,j];
            }
        }
        Console.WriteLine("The Transpose of a matrix is: ");
        for(int i=0;i<col;i++)
        {
            for(int j=0;j<row;j++)
            {
                Console.Write(cop[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}