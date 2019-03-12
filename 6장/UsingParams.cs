using System;

namespace HelloWorld._6장
{
    class MainApp
    {
        static int Sum(params int[] args)
        {
            Console.Write("summing...");

            int sum = 0;
            for (int i = 0; i <args.Length; ++i )
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 5, 6, 2, 32, 4, 2, 5, 5);

            Console.WriteLine($"Sum : {sum}");
        }
    }
}
