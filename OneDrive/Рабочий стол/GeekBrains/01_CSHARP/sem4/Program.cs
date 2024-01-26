// Задайте одномерный массив, заполненный случайными 
// числами. Определите количество простых чисел в этом 
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// тип_метода ИмяМетода (пар1, пар2)
// string - массив char-ов
// char ('+', '-')
// int Calculate(int a, int b, char sign)
// {
//     if (sign == '+')
//     {
//         return a + b;
//     }
//     else if (sign == '-')
//     {
//         return a - b;
//     }
//     else if (sign == '*')
//     {
//         return a * b;
//     }
//     else
//     {
//         Console.WriteLine("Введено неизвестное выражение :(");
//         return 0;
//     }
// }
// // Вызов функции 
// Console.WriteLine(Calculate(2, 3, '+'));
// Console.WriteLine(Calculate(20, 30, '*'));
// Console.WriteLine(Calculate(20, 30, '-'));
// Console.WriteLine(Calculate(20, 30, ','));

// Решение 2

// // тип_метода ИмяМетода (пар1, пар2)
// // string - массив char-ов
// // char ('+', '-')
// int Calculate(int a, int b, char sign)
// {
//     if (sign == '+')
//     {
//         return a + b;
//     }
//     else if (sign == '-')
//     {
//         return a - b;
//     }
//     else if (sign == '*')
//     {
//         return a * b;
//     }
//     else
//     {
//         Console.WriteLine("Введено неизвестное выражение :(");
//         return 0;
//     }
// }
// // Вызов функции 
// int res = Calculate(100, 350, '*');
// Console.WriteLine($"res: {res}");
// Console.WriteLine(Calculate(2, 3, '+'));
// Console.WriteLine(Calculate(20, 30, '*'));
// Console.WriteLine(Calculate(20, 30, '-'));
// Console.WriteLine(Calculate(20, 30, ','));


// Задание 2. Работа в сессионных залах

// Задайте массив из N случайных целых чисел (N вводится с 
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и 
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// size = размер, minRange - мин. число в рандоме, 
// maxRange - макс число в рандоме
// int[] CreateArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size]; // Массив на size эл
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return array;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N, 0, 100);
// // array - массив на N элементов,
// // каждый элемент - число: [0,100]
// Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// // size = размер, minRange - мин. число в рандоме, 
// // maxRange - макс число в рандоме
// int[] CreateArray(int size, int minRange, int maxRange)
// {
//     int[] array = new int[size]; // Массив на size эл
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return array;
// }

// int GetCount(int[] arr)
// {
//     int count = 0;
//     foreach (int number in arr) 
//     {
//         if (number % 7 == 0 && number % 10 == 1)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N, 0, 100);
// // array - массив на N элементов,
// // каждый элемент - число: [0,100]
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Total: {GetCount(array)}");

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// int[] CreateArray(int size)
// {
//     int[] array = new int[size]; // Массив на size эл
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//         // 0, 9
//     }
//     return array;
// }
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N);
// if (array[0] == 0 || N > 8)
// {
//     Console.WriteLine("Размер > 8 эл, или 0 элемент = 0");
//     return;
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// int ConvertArrayToInteger(int[] array)
// {
//     int result = 0;
//     // 294
//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         result = result + array[i] * (int)Math.Pow(10, j);
//     }
//     return result;
// }
// Console.WriteLine($"Число: {ConvertArrayToInteger(array)}");


// ДЗ

// Задача 1: Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа 
// завершается при вводе символа ‘q’ или при вводе 
// числа, сумма цифр которого четная.

// while (true) // Бесконечный цикл
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine(); // Чтение строки ввода пользователя
// if (input == "q") // Проверка на ввод 'q' для выхода
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
// {
// int sum = 0;
// while (number > 0) // Вычисление суммы цифр числа
// {
// sum += number % 10; // Добавление последней цифры к сумме
// number /= 10; // Удаление последней цифры из числа
// }
// if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
// {
// Console.WriteLine("[STOP]");
// break;
// }
// }
// else // Если ввод не является числом и не 'q', повторить запрос
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' .");
// }
// }



// Задача 2: Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в 
// массиве.

// int[] numbers = new int[10]; // Массив для хранения случайных чисел
// Random random = new Random(); // Генератор случайных чисел
// int evenCount = 0; // Счетчик четных чисел
// // Заполнение массива случайными трехзначными числами
// for (int i = 0; i < numbers.Length; i++)
// {
// numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
// Console.Write(numbers[i] + " "); // Вывод сгенерированного числа
// // Проверка на четность и увеличение счетчика
// if (numbers[i] % 2 == 0)
// {
// evenCount++;
// }
// }
// // Вывод количества четных чисел в массиве
// Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");



// Задача 3: Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет 
// последним, второй – предпоследним и т.д.)

// int[] numbers = {1, 3, 5, 6, 7, 8}; // Исходный массив
// int temp;
// // Вывод исходного массива
// Console.Write("Исходный массив: ");
// foreach (int number in numbers)
// {
// Console.Write(number + " ");
// }
// // Реверсирование массива
// for (int i = 0; i < numbers.Length / 2; i++)
// {
// // Меняем местами элементы
// temp = numbers[i];
// numbers[i] = numbers[numbers.Length - 1 - i];
// numbers[numbers.Length - 1 - i] = temp;
// }
// // Вывод измененного массива
// Console.Write("\nПеревернутый массив: ");
// foreach (int number in numbers)
// {
// Console.Write(number + " ");
// }