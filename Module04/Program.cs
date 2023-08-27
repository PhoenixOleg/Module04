using System;

namespace Module04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предварительные задания и свои эксперименты по Модулю 4
            //Tasks();

            Console.WriteLine("Итоговое задание Модуля 4");


            Console.ReadKey();
        }

        static void Tasks()
        {
            Console.WriteLine("Это предварительные задания и свои эксперименты по Модулю 3");

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
            //var inv = true;
            //var result = !inv;
            //Console.WriteLine(result);

            // Задание 4.1.15
            //var a = 6;
            //var b = 7;

            //var c = a != b ? a + b : b;

            //Console.WriteLine(c);

            //Задание 4.1.17
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //var color = Console.ReadLine();

            //if (color == "red")
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Your color is red!");
            //}

            //else if (color == "green")
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Your color is green!");
            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Cyan;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Your color is cyan!");
            //}


            //Задание 4.1.18
            //         Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //         var color = Console.ReadLine();

            //switch (color)
            //{
            //             case "red":
            //		Console.BackgroundColor = ConsoleColor.Red;
            //		Console.ForegroundColor = ConsoleColor.Black;

            //		Console.WriteLine("Your color is red!");
            //	break;
            //             case "green":
            //                 Console.BackgroundColor = ConsoleColor.Green;
            //                 Console.ForegroundColor = ConsoleColor.Black;

            //                 Console.WriteLine("Your color is green!");
            //             break;
            //             case "cyan":
            //                 Console.BackgroundColor = ConsoleColor.Cyan;
            //                 Console.ForegroundColor = ConsoleColor.Black;

            //                 Console.WriteLine("Your color is cyan!");
            //             break;
            //             default:
            //                 Console.BackgroundColor = ConsoleColor.Yellow;
            //                 Console.ForegroundColor = ConsoleColor.Red;

            //                 Console.WriteLine("Your color is yellow!");
            //             break;
            //         }

            //// Задание 4.2.6
            //for (int i = 0; i == 0; i = 0)
            //{
            //    Console.WriteLine("test");
            //}

            //// или так
            //for (;;)
            //{
            //    Console.WriteLine("test");
            //}

            // Задание 4.2.11
            //Console.WriteLine("Цикл while");
            //int k = 0;

            //while (k < 3)
            //{
            //    Console.WriteLine(k);

            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;
            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }

            //    k++;

            //}

            //Console.WriteLine("Цикл do ... while");
            //int t = 0;

            //do
            //{
            //    Console.WriteLine(t);

            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;
            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }

            //    t++;

            //}
            //while (t < 3);


            //foreach для имени
            //==================

            //Console.WriteLine("Введите свое имя");
            //string name = Console.ReadLine();

            //string[] arr_name = new string[name.Length];

            //for (int i = 0; i < arr_name.Length; i++)
            // {
            //    arr_name[i] = name.Substring(i, 1);
            //}

            //Console.WriteLine("Ваше имя по буквам");
            //foreach (string letter in arr_name)
            //{
            //    Console.Write(letter + " ");
            //}

            //Console.WriteLine("Последняя буква Вашего имени " + arr_name [arr_name.Length - 1]);

            // Решение из модуля
            //Console.WriteLine("Введите своё имя");

            //var name = Console.ReadLine();

            //Console.WriteLine("Ваше имя по буквам: ");

            //foreach (var ch in name) // А потому что строка ЭТО МАССИВ СИМВОЛОВ! Там так и было написано
            //{
            //    Console.Write(ch + " ");
            //}

            //Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);
            //===================================================================================


            //Задание 4.3.7
            //Console.WriteLine("Введите своё имя");

            //var name = Console.ReadLine();

            //Console.WriteLine("Ваше имя в обратном порядке:");
            //for (int i = name.Length - 1; i > -1; i--)
            //{
            //    Console.Write(name[i]);
            //}

            //Задание 4.3.9
            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            //foreach (int arr_val in array)
            //{
            //    Console.Write(arr_val);
            //}

            ////По строкам
            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[i, k] + " ");

            //    Console.WriteLine();
            //}

            //Console.WriteLine("\n");

            ////Задание 4.3.11 По столбцам
            ////int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //for (int col = 0; col < array.GetUpperBound(1) + 1; col++)
            //{
            //    for (int row = 0; row < array.GetUpperBound(0) + 1; row++)
            //        Console.Write(array[row, col] + " ");

            //    Console.WriteLine();
            //}

            //Задание 4.3.12
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int swap;
            //for (int i = 0; i <= arr.Length - 2 ; i++)
            //{
            //    for (int j = i + 1; j <= arr.Length - 1; j++)
            //    {
            //        if (arr[i] > arr[j])
            //         {
            //            swap = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = swap;
            //        }
            //    }
            //}

            //foreach (int entity in arr)
            //{
            //    Console.Write(entity);
            //}

            ////Решение из модуля
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int temp;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}


            //// Задание 4.3.13
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int aum = 0;
            //foreach (int item in arr)
            //{
            //    aum += item;
            //}
            //Console.Write(aum);

            //Задание 4.3.14
            //int[][] array = new int[3][];
            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var row_array in array) //Перебираем строки с массивами
            //{
            //    foreach (int item in row_array) //Берем каждый массив-строку и перебираем в нем значения
            //    {
            //        Console.Write(item + " ");
            //    }                
            //}

            //Задание 4.3.15
            //https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays

            //int[] array;
            //array = new int[] { 5, -4, 7, 8, 0, -4, -3, 10, -1, 9 };

            //int counter = 0;
            //foreach (int item in array)
            //{
            //    if (item > 0)
            //    {
            //        //counter += 1;
            //        counter ++; // а так короче
            //    }
            //}
            //Console.Write("Количество положительных элементов в массиве: {0}", counter);

            ////Задание 4.3.16
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //Console.WriteLine("Исходный массив");
            //for (int row = 0; row <= arr.GetUpperBound(0); row++)
            //{
            //    for (int col = 0; col <= arr.GetUpperBound(1); col++)
            //    {
            //        Console.Write(arr[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int swap;
            //// Сортировка по строкам
            //for (int row = 0; row <= arr.GetUpperBound(0); row++) //2 строки
            //{
            //    for (int col = 0; col <= arr.GetUpperBound(1); col++) //5 столбцов
            //    {
            //        for (int col_s = col + 1; col_s <= arr.GetUpperBound(1); col_s++)
            //        {
            //            if (arr[row, col] > arr[row, col_s])
            //            {
            //                swap = arr[row, col];
            //                arr[row, col] = arr[row, col_s];
            //                arr[row, col_s] = swap;
            //            }

            //        }
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Построчно отсортированный массив");
            //for (int row = 0; row <= arr.GetUpperBound(0); row++)
            //{
            //    for (int col = 0; col <= arr.GetUpperBound(1); col++)
            //    {
            //        Console.Write(arr[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////Задание 4.4.2
            //(string name, int age) anketa; //Объявление кортежа

            //Console.Write("Введите Ваше имя: ");
            //anketa.name = Console.ReadLine();

            //Console.Write("Введите Ваш возраст: ");
            //anketa.age = checked(int.Parse(Console.ReadLine()));

            //Console.WriteLine("\nЗдравствуйте, " + anketa.name);
            //Console.WriteLine("Вам {0} лет", anketa.age);

            //// кортеж без имени, но сразу надо задавать значения
            //var (name, age) = ("Евгения", 27);
            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);


            ////Задание 4.4.3
            //var (name, age) = ("Евгения", 27);
            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //Console.Write("Введите Ваше имя: ");
            //name = Console.ReadLine();

            //Console.Write("Введите Ваш возраст: ");
            //age = checked(int.Parse(Console.ReadLine()));

            //Console.WriteLine("\nЗдравствуйте, " + name);
            //Console.WriteLine("Вам {0} лет", age);

            ////Задание 4.4.4
            //(string Name, string Type, double Age) Pet;

            ////Задание 4.4.5
            //(string Name, string Type, double Age, int NameCount) Pet;
            ////Name — имя питомца;
            ////Type — тип питомца: собака, рыбка, хомячок;
            ////Age — возраст питомца;
            ////NameCount — длина имени питомца.

            //Console.Write("Введите имя питомца: ");
            //Pet.Name = Console.ReadLine();

            //Console.Write("Введите вид питомца: ");
            //Pet.Type = Console.ReadLine();

            //Console.Write("Введите Ваш возраст: ");
            //Pet.Age = Convert.ToDouble(Console.ReadLine());

            //Pet.NameCount = Pet.Name.Length;

            //Console.WriteLine("\nВашего питомца зовут " + Pet.Name);
            //Console.WriteLine("Это {0}", Pet.Type);
            //Console.WriteLine($"Ему {Pet.Age} лет");
            //Console.WriteLine("Длина его имени составляет " + Pet.NameCount + " символов");
        }
    }
}
