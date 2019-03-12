using System;

namespace HelloWorld
{
    class NamedParameter
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"name:{name}, phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-123", name: "박지성");
            PrintProfile("박세리", phone: "010-123123-123");
        }

    }
}
