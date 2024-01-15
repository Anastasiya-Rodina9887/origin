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
int[] CreateArray(int size, int minRange, int maxRange)
{
    int[] array = new int[size]; // Массив на size эл
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(N, 0, 100);
// array - массив на N элементов,
// каждый элемент - число: [0,100]
Console.WriteLine($"Массив: [ {string.Join(";", array)} ]");