using System;

namespace HelloWorld._3장
{
    class IntegralLiterals_mainApp
    {
        static void Main(string[] args)
        {
            byte a = 240;
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000;
            Console.WriteLine($"b={b}");

            uint d = 0x1234_abcd;
            Console.WriteLine($"d={d}");
        }
    }
}
