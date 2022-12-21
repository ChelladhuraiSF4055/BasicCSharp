using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("length of a side of the ground within the range of [1 … 100]."); 
        float N=float.Parse(Console.ReadLine());
        Console.WriteLine("width per tile within the range of [0.1 … 10.00]. ");
        float W=float.Parse(Console.ReadLine());
        Console.WriteLine("length per tile within the range of [0.1 … 10.00]. ");
        float L=float.Parse(Console.ReadLine());
        Console.WriteLine("M - width of the bench within the range of [0 … 10]. ");
        int M=int.Parse(Console.ReadLine());
        Console.WriteLine("O - length of the bench within the range of [0 … 10]. ");
        int O= int.Parse(Console.ReadLine());
        float areaOfGround=(float)N*N;
        float areaOfTiles=(float)W*L;
        float areaOfBench=(float)M*O;
        double numOfTiles=(double)(areaOfGround-areaOfBench)/areaOfTiles;
        Console.WriteLine($"Total number of Tiles needed: {numOfTiles}");
        double time=(double)0.2*numOfTiles;
        Console.WriteLine($"Total Time required to replace: {time} minutes");

    }
}