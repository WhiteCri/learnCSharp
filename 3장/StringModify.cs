using static System.Console;

namespace HelloWorld._4장
{
    class StringModify
    {
        static void Main(string[] args)
        {
            WriteLine("Lower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abs".ToUpper());

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            WriteLine("Remove() : '{0}'", "I Don't love you".Remove(2, 6));

            WriteLine("Trim() : '{0}'", " No spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No spaces ".TrimEnd());
        }
    }
}
