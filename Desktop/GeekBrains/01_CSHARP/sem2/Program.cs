// // Напишите программу, которая принимает на вход
// // трёхзначное число и удаляет вторую цифру этого
// // числа.
// // Примеры
// // a = 256 => 26
// // a = 891 => 81

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И": яблоки И апельсины (и то, и другое нужно купить)
// // "||" - "ИЛИ": яблоки ИЛИ апельсины(что-то одно, либо все вместе)
// if (number >= 100 && number <= 999) // Число - трехзначное
// {
//     int firstDigit = number / 100; // 274 / 100 = 2
//     int thirdDigit = number % 10; // 274 % 10 = 4
//     int result = firstDigit * 10 + thirdDigit;
//     // Интерполяция: $"Значение переменной {thirdDigit} = {}"
//     Console.WriteLine($"Результат от числа {number} = {result}");
// }
// else // Число НЕ трехзначное
// {
//     Console.WriteLine("Число НЕ трехзначное");
// }


// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int secondDigit = number / 10 % 10; // 487 / 10 % 10 = 48 % 10 = 8
//     int thirdDigit = number % 10; // 487 % 10 = 7
//     // Math.Pow(5, 2) => 5 в 2 степени => 25
//     int result = (int)Math.Pow(secondDigit, thirdDigit);
//     Console.WriteLine($"Число {number}: {secondDigit}^{thirdDigit} = {result}");
// }
// else // Число НЕ трехзначное
// {
//     Console.WriteLine("Число НЕ трехзначное");
// }

// Получите 3 цифру введенного числа слева (с начала)
// 1234567 => 3
// 7891 => 9
// 32 => 3 цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число трехзначное
// {
//     while (number > 999) // Если в числе минимум 4 цифры, я делю :)
//     {
//         number /= 10; 
//     }
//     Console.WriteLine($"Третья цифра от числа  {copyNumber} = {number % 10}");
// }


// Получи третью цифру справа:
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число минимум трехзначное 
// {
//     int digitCount = 0; // Количество цифр, которое нужно убрать 
//     int digit = 0; // Третья цифра справа
//     while (digitCount < 2) // Отбрасываем 2 последние цифры
//     {
//         number /= 10;
//         digitCount++; // digitCount = digitCount + 1
//     }
//     Console.WriteLine($"Третья цифра справа от числа {copyNumber} = {number % 10}");
// }

// int number = 123;
// Console.WriteLine(number / 100 % 10);

// TryParse

// int a = 14;

// if (a % 7 == 0)
// {
//     Console.WriteLine($"{a} кратно 7");
// }

//  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 == 0 && a % 23 == 0)
// {
// Console.WriteLine("да");
// }
// else
// {
// Console.WriteLine("нет");
// }

// Console.Write("Введите координаты точки X и Y через пробел: ");
// string[] coordinates = Console.ReadLine().Split(' ');
// int x = Convert.ToInt32(coordinates[0]);
// int y = Convert.ToInt32(coordinates[1]);
// if (x > 0 && y > 0)
// Console.WriteLine("1");
// else if (x < 0 && y > 0)
// Console.WriteLine("2");
// else if (x < 0 && y < 0)
// Console.WriteLine("3");
// else if (x > 0 && y < 0)
// Console.WriteLine("4");
// else
// Console.WriteLine("Точка находится на оси координат");

// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Console.Write("Введите число из отрезка [10, 99]: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine(maxDigit);

// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 10)
// {
// Console.WriteLine(N);
// }
// else
// {
// while (N > 0);

// int currentDigit = N % 10;
// N /= 10;
// if (N > 0)
// {
// Console.Write(currentDigit + ",");
// }
// else
// {
// Console.WriteLine(currentDigit);
// }
// }




