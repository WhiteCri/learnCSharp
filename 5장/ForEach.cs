using System;

namespace HelloWorld._5장
{
    class ForEach
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            foreach (int a in arr)
                Console.WriteLine(a);
        }
    }
}
