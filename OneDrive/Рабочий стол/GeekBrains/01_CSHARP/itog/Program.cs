Задача 1: Задайте значения M и N. Напишите 
программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не 
использовать циклы.

M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите 2 числа:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbersMN(int start, int end)
{
    if (end > start)
{
        PrintNumbersMN(start,end-1);
}
    Console.Write(end + ", ");
}

if (m < n){
    PrintNumbersMN(m,n);
}
else{
    PrintNumbersMN(n,m);
}

Задача 2: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n. 

m = 2, n = 3 -> A(m,n) = 29 - в задании опечатка, так как ответ будет 9 (перепроверила через калькулятор)

Функция Аккермана является примером рекурсивной функции, которая используется для демонстрации механизма рекурсии и ее ограничений. 
Она определяется математической формулой: 
A(m,n) = n+1, если m=0 
A(m,n) = A(m-1,1), если m>0 и n=0 
A(m,n) = A(m-1,A(m,n-1)), если m>0 и n>0 
Где m и n – целые неотрицательные числа. Функция Аккермана принимает на вход два аргумента и возвращает единственное число – результат вычисления функции.

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

Задача 3: Задайте произвольный массив. Выведете 
его элементы, начиная с конца. Использовать 
рекурсию, не использовать циклы.

[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

Console.Write("Введите массив:");
int array = Convert.ToInt32(Console.ReadLine());

void ReverseArray(int [] array, int i)
{
if (i <= 0)
{
return;
}
int temp = array[i];
array[i] = array[array.Length - i-1];
array[array.Length - i-1] = temp;
return (array,i -= 2);
}
Console.Write($"Реверсивный массив = {ReverseArray} ");