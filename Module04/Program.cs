using System;

namespace Module04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4.1.4
            //string a = "a";
            //string b = "b";
            //bool c = a != b;

            //Console.WriteLine(c);

            //Задание 4.1.5
            //int a = 5;
            //int b = 7;
            //double x = 10.7;
            //double y = 12.5;

            //bool c = (a < b) | (x > y);

            // || и && Вычисляют только первую часть выражения, если результат false для && (true для ||) вычисляется дальше -> экономия ресурсов
            // | и & Вычисляют ВСЕ части выражения
            //Console.WriteLine(c);

            //Задание 4.1.10
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);

            // Задание 4.1.15
            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
