using System;
namespace IfPractise;
    class Program{
        public static void Main(string[] args)
        {
            
            Console.WriteLine("What do you like to have?");
            string option=Console.ReadLine();
            if (option=="tea")
            {
                Console.WriteLine("Tea Selected");
            }
            else if(option=="coffee")
            {
                Console.WriteLine("Coffee Selected");
            }
            else
            {
                Console.WriteLine("Wrong Selection");
            }
        }
    }