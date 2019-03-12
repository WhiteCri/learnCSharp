using System;
using HelloWorld._7장;
namespace HelloWorld._7장
{
    public static class vitamin7_1
    {
        public static string append(this string str1, string str2)
        {
            return str1 + str2;
        }
    }

    class MainApp
    {
        public static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.append(", World!"));
        }
    }
}