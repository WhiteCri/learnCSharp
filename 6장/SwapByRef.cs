using System;

namespace HelloWorld._6장
{
    class MainApp
    {
        static void Swap(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x : {x}, y : {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x : {x}, y : {y}");
        }
    }
}
