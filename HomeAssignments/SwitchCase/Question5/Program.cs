using System;
namespace Question5;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choices:");
        Console.WriteLine("1.India\n2.Pakistan\n3.Bangladesh");
        Console.WriteLine("Select Country:");
        int country=Convert.ToInt32(Console.ReadLine());
        switch(country)
        {
            case 1: Console.WriteLine("1. Gambhir\n2. Ashwin\n3. Dhoni\n4. Jadeja");
            break;
            case 2: Console.WriteLine("1. Afridi\n2. Ali\n3. Mohammed\n4. ImranKhan");
            break;
            case 3: Console.WriteLine("1. LittonDas\n2.TamimIqbal\n3. mahamudullah\n4. sabir rahman");
            break;
        }

    }
}