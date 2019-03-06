using System;

namespace HelloWorld._3장
{
    class Overflow
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;
            Console.WriteLine(a);
            a = a + 1;
            Console.WriteLine(a);
        }
    }
}
