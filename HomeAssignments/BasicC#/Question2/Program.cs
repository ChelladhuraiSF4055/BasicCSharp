using System;
namespace Question2{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Input the first number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number:");
            int num2=Convert.ToInt32(Console.ReadLine());
            //additon
            int add=num1+num2;
            Console.WriteLine($"{num1}+{num2}={add}");
            //subraction
            int sub=num1-num2;
            Console.WriteLine($"{num1}-{num2}={sub}");
            //multiplication
            int mul=num1*num2;
            Console.WriteLine($"{num1}*{num2}={mul}");
            //division
            int div=num1%num2;
            Console.WriteLine($"{num1}%{num2}={div}");

            
        }
    }
}