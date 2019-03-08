﻿using static System.Console;
using System;

namespace HelloWorld._4장
{
    class StringSlice
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            WriteLine(greeting.Substring(0, 5));//Good
            WriteLine(greeting.Substring(5));//morning
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}
