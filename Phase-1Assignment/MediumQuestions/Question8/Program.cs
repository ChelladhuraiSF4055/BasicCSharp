using System;
namespace Question8;
class Program{
    public static void Main(string[] args)
    {
        string inp="Ra12fla4mg32";
        int number;
        string res="";
        string[]arr=inp.Split();
        foreach(var i in inp)
        {
            if(int.TryParse(i.ToString(),out number))
            {
               res+=number.ToString();
            }
        }
        int n =int.Parse(res.ToCharArray());
        if(n%2==0)
        {
            Console.WriteLine($"{n} is an Even number.");
        }
        else{
            Console.WriteLine($"{n} is an odd number.");
        }
        
    }
}