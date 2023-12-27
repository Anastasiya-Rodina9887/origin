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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number < 100) // Число не трехзначное
{
    Console.WriteLine("Третьей цифры нет :)");
}
else // Число трехзначное
{
    while (number > 999) // Если в числе минимум 4 цифры, я делю :)
    {
        number /= 10; 
    }
    Console.WriteLine($"Третья цифра от числа  {copyNumber} = {number % 10}");
}