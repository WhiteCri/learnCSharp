using System;

namespace HelloWorld._7장
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
        public string Name;
        public string Color;
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat Kitty = new Cat("키디", "하얀색");
            Kitty.Meow();
            Console.WriteLine($"{Kitty.Name} : {Kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
