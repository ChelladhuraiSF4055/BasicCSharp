﻿using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Test Data : ");
        int data=Convert.ToInt32(Console.ReadLine());
        if (data/2!=0)
        {
            Console.WriteLine($"{data} is an odd integer");
        }
        else
        {
            Console.WriteLine($"{data} is an even integer");
        }
    }
}