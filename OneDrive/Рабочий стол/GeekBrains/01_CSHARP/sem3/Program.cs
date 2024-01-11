// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. Программа 
// должна выдать ответ: Да/Нет.

// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 
// using System.Runtime.InteropServices;

// int[] array = {11, 22, 33, 44, 55, 66, 77 };
// Console.Write("Введите число для поиска в массиве: ");
// int numberForSearch = Convert.ToInt32(Console.ReadLine());
// bool isFound = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (numberForSearch == array [i]);
//     {
//         isFound = true;
//         break;
//     }
// }
// if (isFound)
// {
//     Console.WriteLine(" Да ");
// }
// else
// {
//     Console.WriteLine(" Нет ");
// }

// int[] array = {11, 22, 33, 44, 55, 66, 77 };
// Console.Write("Введите число для поиска в массиве: ");
// int numberForSearch = Convert.ToInt32(Console.ReadLine());
// string isFound = "не найден";

// for (int i = 0; i < array.Length; i++)
// {
//     if (numberForSearch == array[i])
//     {
//         isFound = "найден";
//         break;
//     }
// }
// Console.WriteLine($"Элемент {numberForSearch}: {isFound} ");


// Задайте массив из 10 элементов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные элементы на 
// положительные, а положительные на отрицательные.

// Пример
// [1 -5 6]
// => [-1 5 -6]

// int[] array = {1, -2, 3, 4, 5, -1, -7, -9, 10, -5 };
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;  // array[i] = array[i] * -1;
//     Console.Write(array[i] + "\t");
// }


// int[] array = {1, -2, 3, 4, 5, -1, -7, -9, 10, -5 };
// Console.WriteLine($"Массив ДО: [ {string.Join("; ", array)} ]");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;  // array[i] = array[i] * -1;
// }
// Console.WriteLine($"Массив ПОСЛЕ: [ {string.Join("; ", array)} ]");





