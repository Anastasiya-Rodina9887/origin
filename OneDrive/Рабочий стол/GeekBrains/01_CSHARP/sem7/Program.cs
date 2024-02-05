// // Напишите программу, 
// // которая будет принимать на вход число
// //  и возвращать сумму его цифр. Задача 1.
// int SumOfDigitsReq(int n)
// {
//     if (n < 10)
//     {
//         return n;
//     }
//     int lastDigit = n % 10;
//     n /= 10;
//     return lastDigit + SumOfDigitsReq(n);
// }

// //Console.WriteLine(SumOfDigitsReq(0));

// // Задача 2
// // Задайте значение N. Напишите программу, которая выведет 
// // все натуральные числа в промежутке от 1 до N.

// void PrintNumbers(int n){
//     if (n>1){
//         PrintNumbers(n-1);
//     }
//     Console.WriteLine(n);
// }
// //int n = Convert.ToInt32(Console.ReadLine());
// //PrintNumbers(n);


// // Задайте значения M и N. Напишите программу, 
// // которая выведет все натуральные числа 
// // в промежутке от M до N. Задача 3


// //Console.WriteLine("Введите 2 числа:");
// // int m = Convert.ToInt32(Console.ReadLine());
// // int n1 = Convert.ToInt32(Console.ReadLine());

// void PrintNumbersMN(int start, int end){
//     if (end > start){
//         PrintNumbersMN(start,end-1);
//     }
//     Console.WriteLine(end);
// }

// // if (m < n1){
// //     PrintNumbersMN(m,n1);
// // }
// // else{
// //     PrintNumbersMN(n1,m);
// // }

// // Считать строку с консоли, содержащую латинские буквы. 
// // Вывести на экран согласные буквы этой строки. 
// // Указание Использовать рекурсию. Не использовать цикл. 
// // Пример “hello” => h l l “World” => W r l d “Hello world!” => 
// // H l l w r l d Задача 4

// Console.WriteLine("Введите строку:");
// string sentence = Console.ReadLine();
// void PrintLetter(string str, int i=0){
//     string vovels = "aoiyeu";
//     if (!vovels.Contains(str[i])){
//             Console.Write(str[i] + " ");
//     }
//     if (i < str.Length-1){
//         PrintLetter(str, i+1);
//     }

// }
// PrintLetter(sentence);

// // Напишите программу, которая на вход принимает 
// // два числа A и B, и возводит число А в целую степень 
// // B с помощью рекурсии. Задача 5
// Console.WriteLine("Введите A:");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите B:");
// int B = Convert.ToInt32(Console.ReadLine());
//  int PowAInB (int number, int rank){
//    if (number ==0 || number ==1){
//     return number;
//    }
//     if (rank == 0){
//         return 1;
//     }
//     if (rank ==1){
//         return number;
//     }
//     return number*=PowAInB(number,rank-1);
    
//  }

// Console.WriteLine($"{A} в степени {B} = {PowAInB(A,B)}");

