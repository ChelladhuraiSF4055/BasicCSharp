using System;
namespace Question10{
    class Program{
        public static void Main(string[] args)
        {
            int Value1=15;
            int Value2=20;
            Console.WriteLine($"a.  {Value1 > Value2}");
            Console.WriteLine($"b.  {Value1 < Value2}");
            Console.WriteLine($"c.  {Value1 >= Value2}");
            Console.WriteLine($"d.  {(Value1 == Value2)}");
            Console.WriteLine($"e.  {Value1 != Value2}");
            Console.WriteLine($"f.  {Value1 <= Value2}");
            Console.WriteLine($"g.  {Value1>=10 && Value2>=10}");
            Console.WriteLine($"h.  {Value1 >=10 || Value2 >= 30}");
            Console.WriteLine($"i.  {!(Value1>20)}");
            String value = Value1 ==15 ? "true" : "false";
            Console.WriteLine($"j.  {value}");
            Console.WriteLine($"k.  {Value1++}");
            Console.WriteLine($"l.  {Value1 --}");
        }
    }
}