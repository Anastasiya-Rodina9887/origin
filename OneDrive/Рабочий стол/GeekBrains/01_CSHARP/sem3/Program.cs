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

// int[] array = {1, -2, 3, 4, 5, -1, -7, -9, 10, -5 };
// int sum = 0;
// for (int i = 1; i < 5; i++)
// {
//     sum = sum + array[i];
// }
// Console.WriteLine(sum);

// int[] array = {1, -2, 3, 4, 5, -1, -7, -9, 10, -5 };
// int count = 0;
// for (int i = 1; i < 5; i++)
// {
//     count++;
// }
// Console.WriteLine(count);

// Найдите произведения пар чисел в одномерном массиве. Парой 
// считаем первый и последний элемент, второй и предпоследний и 
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)


int[] array = { 1, -2, 3, 4, 5, -1, -7, -9, 10, -5 };
int[] result = new int[array.Length / 2];
 // i - индекс 1 элемента, j - индекс послеж=днего элемента
for (int i = 0; j = array.Length - 1; i < result.Length; i++, j--)
{
    result[i] = array[i] * array[j];
}
 Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
 Console.WriteLine($"Результат: [ {string.Join("; ", result)} ]");

