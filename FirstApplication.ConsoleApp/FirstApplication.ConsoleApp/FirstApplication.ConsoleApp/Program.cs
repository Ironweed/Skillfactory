﻿using System;

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
            //Финальная практика модуля «Анкетируем пользователей»

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));
            
            Console.WriteLine("Ваще имя {0} и ваш возраст {1} ", name, age);

            Console.Write("Введите ваш день рождения: ");
            string birthdate = Console.ReadLine();

            Console.WriteLine("Ваш день рождения: {0} ", birthdate);



//             // дописать код
//             Console.Write("Enter your name: ");
//             var name = Console.ReadLine();
// 
//             var age = checked((byte)int.Parse(Console.ReadLine()));
//             Console.WriteLine("Your name is {0} and age is {1} ", name, age);
// 
//             Console.Write("What is your favorite day of week? ");
// 
//             var day = (DayOfWeek)int.Parse(Console.ReadLine());
//             Console.WriteLine("Your favorite day is {0}", day);
// 
//             //преобразование типов
// 
//             Console.Write("Enter your name: ");
//             /*string*/ name = Console.ReadLine();
//             /*var*/ age = checked((byte)int.Parse(Console.ReadLine()));
//             Console.WriteLine("Your name is {0} and age is {1} ", name, age);
//             Console.Write("What is your favorite day of week? ");
//             /*var*/ day = (DayOfWeek)int.Parse(Console.ReadLine());
//             Console.WriteLine("Your favorite day is {0}", day);
//             Console.ReadKey();
// 
//             Console.Write("Enter your name: ");
//             /*string */name = Console.ReadLine();
//             Console.Write("Enter your age: ");
//             /*byte */age = checked((byte)int.Parse(Console.ReadLine()));
//             Console.WriteLine("Your name is {0} and age is {1} ", name, age);
//             Console.Write("Какой ваш любимый день недели?");
//             DaysOfWeek MyFavoriteDay = (DaysOfWeek)int.Parse(Console.ReadLine());
//             Console.WriteLine("Ваш любимы день недели {0}", MyFavoriteDay.ToString());
// 
//             Console.ReadKey();
// 
// 
//             Console.Write("Enter your name: ");
//             /*string */name = Console.ReadLine();
//             Console.Write("Enter your age: ");
//             /*byte */age = checked((byte)int.Parse(Console.ReadLine()));
//             Console.WriteLine("Your name is {0} and age is {1} ", name, age);
//             Console.ReadKey();
// 
// 
// 
//             double result1 = 10 % 3;
//             Console.WriteLine("double result1 = 10 % 3; Result {0} ", result1);
// 
// 
//             int k = -10;
//             int b = 10;
//             b -= k;
// 
//             double d1 = 5 / 2 * 3;
//             Console.WriteLine("d1 = 5 / 2 * 3; Result {0} ", d1);
//             d1 = 5.0 / 2.0 * 3.0;
//             Console.WriteLine("d1 = 5.0 / 2.0 * 3.0; Result {0} ", d1);
// 
// 
// 
//             int counter = 10;
//             Console.WriteLine("Value : {0} Increment: {1}", counter, counter++);
// 
//             double division = 5.0 / 2.0;
//             Console.WriteLine("5.0 / 2.0 = {0}", division);
//             division = 5 / 2;
//             Console.WriteLine("5 / 2 = {0}", division);
// 
//             division = 10.0 / 4.0;
//             Console.WriteLine("5.0 % 2.0 = {0}", division);
// 
// 
//             string CompName = "Computer";
//             Console.WriteLine("Привет, человек");
//             Console.WriteLine("Меня зовут {0}", CompName);
//             Console.Write("А как тебя зовут? ");
//             string YourName = Console.ReadLine();
//             Console.Write("Рад встрече, {0} ", YourName);
// 
// 
//             string MyName = "Евгения";
//             Console.WriteLine("Привет, Мир");
//             Console.WriteLine();
//             Console.WriteLine($"Меня зовут {MyName}");
// 
//             Console.ReadKey();
// 
//             Console.WriteLine( "\t\t Привет,\n мир!");
// 
//             /*DaysOfWeek MyFavoriteDay;*/
//             MyFavoriteDay = DaysOfWeek.Friday;
// 
//             Console.WriteLine(MyFavoriteDay);
// 
//             //Console.WriteLine("IntMin {0} ", int.MinValue);
//             //Console.WriteLine("IntMax {0} ", int.MaxValue);
// 
//             Console.WriteLine("Как Вас зовут?");
//             name = Console.ReadLine();
// 
//             int number;
//             Console.WriteLine("Сколько Вам лет?");
//             string input = Console.ReadLine();
//             bool result = int.TryParse(input, out number);
//             age = (byte) number;
// 
// 
//             bool pet;
//             Console.WriteLine("Есть ли у вас питомец?");
//             string input1 = Console.ReadLine();
// 
//             switch (input1)
//             {
//                 case "нет":
//                     pet = false;
//                     break;
//                 case "да":
//                     pet = true;
//                     break;
//                 default:
//                     Console.WriteLine("Ответ не распознан, установлено НЕТ");
//                     pet = false;
//                     break;
//             }
//             
// 
//             double size;
//             Console.WriteLine("Какой у вас размер ноги?");
//             string input2  = Console.ReadLine();
//             bool result2 = double.TryParse(input2, out size);
// 
//             Greet(name, age, pet, size);
//             Console.WriteLine("Рад был познакомиться!");
        }

        static void Greet(string _name, byte _age, bool _pet, double _size)
        {
            Console.WriteLine($"Моё имя {_name}");
            Console.WriteLine($"Мне  {_age} лет");
            Console.WriteLine($"У меня  " + (_pet? "есть" : "нет") + (_pet ? " питомец":" питомеца"));
            Console.WriteLine($"My shoe size is {_size}");

            //Console.WriteLine("Здравствуйте, {0}", _name);
            //Console.WriteLine("Мне сообщили, что Вам {0}", _age);
        }


    }


}
