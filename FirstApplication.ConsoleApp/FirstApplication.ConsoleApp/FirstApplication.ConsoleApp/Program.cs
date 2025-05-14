using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        enum DaysOfWeek : byte
        {
            Tuesday,
            Monday = 1,
            Wednesday,
            Friday
        }

        enum Semaphore
        {
            Red = 100, 
            Yellow = 200, 
            Green = 300
        }

        static void Main(string[] args)
        {
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);

            //Console.WriteLine("IntMin {0} ", int.MinValue);
            //Console.WriteLine("IntMax {0} ", int.MaxValue);

            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();

            byte age;
            int number;
            Console.WriteLine("Сколько Вам лет?");
            string input = Console.ReadLine();
            bool result = int.TryParse(input, out number);
            age = (byte) number;


            bool pet;
            Console.WriteLine("Есть ли у вас питомец?");
            string input1 = Console.ReadLine();

            switch (input1)
            {
                case "нет":
                    pet = false;
                    break;
                case "да":
                    pet = true;
                    break;
                default:
                    Console.WriteLine("Ответ не распознан, установлено НЕТ");
                    pet = false;
                    break;
            }
            

            double size;
            Console.WriteLine("Какой у вас размер ноги?");
            string input2  = Console.ReadLine();
            bool result2 = double.TryParse(input2, out size);

            Greet(name, age, pet, size);
            Console.WriteLine("Рад был познакомиться!");
        }

        static void Greet(string _name, byte _age, bool _pet, double _size)
        {
            Console.WriteLine("Моё имя " + _name);
            Console.WriteLine("Мне  " + _age + " лет");
            Console.WriteLine("У меня  " + (_pet? "есть" : "нет") + (_pet ? " питомец":" питомеца"));
            Console.WriteLine("My shoe size is " + _size);

            //Console.WriteLine("Здравствуйте, {0}", _name);
            //Console.WriteLine("Мне сообщили, что Вам {0}", _age);
        }


    }


}
