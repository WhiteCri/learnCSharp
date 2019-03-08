using static System.Console;

namespace HelloWorld._4장
{
    class StringSearch
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            WriteLine("Indexof 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            WriteLine("LastIndexof 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            WriteLine("EndsWidth 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWidth 'Morning' : {0}", greeting.EndsWith("Morning"));

            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            WriteLine("replaced 'Morning' with 'evening' : {0}",
                greeting.Replace("Morning", "Evening"));
        }
    }
}
