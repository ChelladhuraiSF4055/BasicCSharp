using System;
namespace TypeConvertion{
    class Program{
        public static void Main(string[] args)
        {
            int value1=10;
            //Implicit Conversion
            double value2=value1;
           
            //Explicit Conversion
             double result= (double)value1/value2;
            int number;
            Console.Write("Enter the number:");
            bool temp=int.TryParse(Console.ReadLine(),out number);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(result);
            Console.WriteLine(temp);
            Console.WriteLine(number);
        }
    }
}