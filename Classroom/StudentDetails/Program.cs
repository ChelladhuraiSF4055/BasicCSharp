using System;
namespace StudentDetails{
    class Program{
        public static void Main(string[] args)
        {
           Console.Write("Enter your name: ");
           String name=Console.ReadLine();
           Console.Write("Enter age: ");
           int age= Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter mark of subject1: ");
           int sub1=Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter mark of subject2: ");
           int sub2=Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter mark of subject3: ");
           int sub3=Convert.ToInt32(Console.ReadLine());
           Console.Write("Enter Grade: ");
           string grade=Console.ReadLine();
           Console.Write("Enter mobile number: ");
           long mobile= Convert.ToInt64(Console.ReadLine());
           Console.Write("Enter Mail id: ");
           string mail=Console.ReadLine();
           int total=(sub1+sub2+sub3);
           float avg=total/3;

           Console.WriteLine("Trainee Details Are:");
           Console.WriteLine($"Name: {name}");
           Console.WriteLine($"Age: {age}");
           Console.WriteLine($"Mobile: {mobile}");
           Console.WriteLine($"Marks1: {sub1}");
           Console.WriteLine($"Marks2: {sub2}");
           Console.WriteLine($"Marks3: {sub3}");
           Console.WriteLine($"Total: {total}");
           Console.WriteLine($"Average: {Math.Round(avg,2)}");
           Console.WriteLine($"Grade: {grade}");
           Console.WriteLine($"Mail id: {mail}");

        }
    }
}