using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input radius of the circle: ");
        int radius=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1. Area\n2. Perimeter\n3. Diameter\n");
        Console.WriteLine("Choice: ");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:  double area =3.14*radius*radius;
            Console.Write($"The area is : {area}");
            break;
            case 2: float perimeter=(float)2*3.14*radius;
            Console.WriteLine($"The perimeter is : {perimeter}");
            break;
            case 3: double diameter=2*radius;
            Console.WriteLine($"The diameter is: {diameter}");
            break;
        }
    }
}