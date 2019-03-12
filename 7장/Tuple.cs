using System;

namespace HelloWorld._7장
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1}, {a.Item2}");

            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");

            //분해
            var (name, age) = b;
            Console.WriteLine($"{name}, {age}");

            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");
        }
    }
}
