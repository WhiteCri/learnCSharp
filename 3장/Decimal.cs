using System;

namespace HelloWorld._3장
{
    class Decimal
    {
        static void Main(string[] args)
        {
            float a = 3.14159265358979323846_2643383279f;
            double b = 3.14159265358979323846_2643383279;
            decimal c = 3.14159265358979323846_2643383279m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
