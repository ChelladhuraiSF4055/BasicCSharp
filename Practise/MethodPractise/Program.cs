using System;
namespace MethodPractise;
class Program{
    public static void Main(string[] args)
    {
        //method with argument and with return type
        Console.WriteLine(Addition(2,3));

        //method with argument without return type
        Subraction(3,2);

        //method without argument with return type
        int result=Multiplication();

        //method without argument without return type
        division();


        int Addition(int value1, int value2)
        {
            return value1+value2;
        }

        void Subraction(int value1,int value2)
        {
            int sub=value1-value2;
            Console.WriteLine(sub);
        }

        int Multiplication()
        {
            int value1=3;
            int value2=2;
            int mul=value1*value2;
            return mul;
        }

        void division()
        {
            int value1=10;
            int value2=3;
            Console.WriteLine(value1/value2);
        }

    }
}