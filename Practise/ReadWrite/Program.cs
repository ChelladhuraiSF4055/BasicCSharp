using System;
namespace ReadWrite{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string myName=Console.ReadLine();
            Console.WriteLine("Enter your father Name:");
            string fatherName=Console.ReadLine();
            //String Concatenation
            Console.WriteLine("My name is "+myName+" My father name is "+fatherName);
            //Placeholder
            Console.WriteLine("My name is {0} and My father name is {1}",myName,fatherName);
            //Interpolation
            Console.WriteLine($"My name is {myName} and My father name is {fatherName}");
            

        }
    }
}
