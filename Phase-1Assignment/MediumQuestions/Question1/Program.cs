using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your basic salary: ");
        int baSalary=Convert.ToInt32(Console.ReadLine());
        int hra=0;
        int da=0;
        int groAnnSalary;
        int insurance;
        int taxed;
        int actSalary;
        if(baSalary<=10000)
        {
            hra=20*baSalary/100;
            da=80*baSalary/100;
        }
        else if(baSalary<=20000)
        {
            hra=25*baSalary/100;
            da=90*baSalary/100;
        }
        else if(baSalary>20000)
        {
            hra=30*baSalary/100;
            da=95*baSalary/100;
        }
        groAnnSalary=(baSalary+hra+da)*12;
        taxed=groAnnSalary*6/100;
        insurance=groAnnSalary*1/100;
        actSalary=groAnnSalary-taxed-insurance;
        Console.WriteLine($"The Annual Gross salary is: {groAnnSalary}");
        Console.WriteLine($"The Annual Take home salary is : {actSalary}");
    }
}