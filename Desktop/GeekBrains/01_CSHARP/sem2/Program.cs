﻿Напишите программу, которая принимает на вход
трёхзначное число и удаляет вторую цифру этого
числа.
Примеры
a = 256 => 26
a = 891 => 81

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// "&&" - "И": яблоки И апельсины (и то, и другое нужно купить)
// "||" - "ИЛИ": яблоки ИЛИ апельсины(что-то одно, либо все вместе)
if (number >= 100 && number <= 999) // Число - трехзначное
{
    int firstDigit = number / 100; // 274 / 100 = 2
    int thirdDigit = number % 10; // 274 % 10 = 4
    int result = firstDigit * 10 + thirdDigit;
    // Интерполяция: $"Значение переменной {thirdDigit} = {}"
    Console.WriteLine($"Результат от числа {number} = {result}");
}
else // Число НЕ трехзначное
{
    Console.WriteLine("Число НЕ трехзначное");
