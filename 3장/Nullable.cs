using System;

namespace HelloWorld._3장
{
    class Nullable
    {
        static void Main(string[] args)
        {
            int? a = null;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}
