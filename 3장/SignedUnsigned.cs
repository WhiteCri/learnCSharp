using System;


namespace HelloWorld._3장
{
    class SignedUnsigned
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
