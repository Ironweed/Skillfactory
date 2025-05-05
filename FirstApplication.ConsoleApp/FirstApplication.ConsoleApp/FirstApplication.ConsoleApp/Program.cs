using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            string age = Console.ReadLine();
            Greet(name, age);
            Console.WriteLine("Рад был познакомиться!");
        }

        static void Greet(string name, string age)
        {
            Console.WriteLine("Здравствуйте, {0}", name);
            Console.WriteLine("Мне сообщили, что Вам {0}", age);
        }

    }
}
