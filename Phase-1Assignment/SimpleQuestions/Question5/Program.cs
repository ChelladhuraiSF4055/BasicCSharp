using System;
namespace Quesiton5;
class Program{
    public static void Main(string[] args)
    {
        int salary=10000;
        int da=10*salary/100;
        int hra=10*salary/100;
        int annSalary=(salary+da+hra)*12;
        int annualTax=5*annSalary/100;
        int actSalary=annSalary-annualTax;
        Console.WriteLine($"Annual Income: {actSalary}");
    }
}