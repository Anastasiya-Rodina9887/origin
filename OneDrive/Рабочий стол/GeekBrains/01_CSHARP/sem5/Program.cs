// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// int[,] CreateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols]; // Матрица размером rows стр и cols столбцов
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     // matrix.GetLength(0) = rows, цикл по стрч
//     {
//         // j, m, k
//         for (int j = 0; j < cols; j++)// matrix.GetLength(1) = rows, цикл по cтолб
//         {
//             matrix[i, j] = rnd.Next(11); // [0;10], 11 не входит
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             Console.Write($"{matr[i, j]}\t"); // \t = 4 пробела между эл
//         }
//         Console.WriteLine();
//     }
// }

// // Вызов функции 
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] res = CreateMatrix(rows, columns);
// PrintMatrix(res);

// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

// int[,] CreateMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols]; // Матрица размером rows стр и cols столбцов
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     // matrix.GetLength(0) = rows, цикл по стрч
//     {
//         // j, m, k
//         for (int j = 0; j < cols; j++)// matrix.GetLength(1) = rows, цикл по cтолб
//         {
//             matrix[i, j] = rnd.Next(11); // [0;10], 11 не входит
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             Console.Write($"{matr[i, j]}\t"); // \t = 4 пробела между эл
//         }
//         Console.WriteLine();
//     }
// }

// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i,j] *= matr[i,j]; // matr[i,j] = matr[i,j] * matr[i,j];
//             }
//         }
//     }
// }


// // Вызов функции 
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] res = CreateMatrix(rows, columns);
// PrintMatrix(res); // Матрица ДО
// Console.WriteLine("Результат: ");
// SquareElements(res); // Возведение в квадрат эл. 
// PrintMatrix(res); // Матрица ПОСЛЕ


// // Задайте двумерный массив. Найдите сумму элементов,
// // находящихся на главной диагонали (с индексами (0,0); (1;1) и
// // т.д.

// int GetMainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             if (i == j) // Номер стр = номер стлбц
//             {
//                 sum += matr[i, j]; // sum = sum + matr[i, j];
//             }
//         }
//     }
//     return sum;
// }


// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i,j] *= matr[i,j]; // matr[i,j] = matr[i,j] * matr[i,j];
//             }
//         }
//     }
// }

// // Вызов функции 
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] res = CreateMatrix(rows, columns);
// PrintMatrix(res); // Матрица ДО
// Console.WriteLine("Результат: ");
// // SquareElements(res); // Возведение в квадрат эл. 
// PrintMatrix(res); // Матрица ПОСЛЕ
// Console.WriteLine($"Total: {GetMainDiagonalSum(res)}");


// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.

// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols]; // Матрица размером rows стр и cols столбцов
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    // matrix.GetLength(0) = rows, цикл по стрч
    {
        // j, m, k
        for (int j = 0; j < cols; j++)// matrix.GetLength(1) = rows, цикл по cтолб
        {
            matrix[i, j] = rnd.Next(11); // [0;10], 11 не входит
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
    {
        for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
        {
            Console.Write($"{matr[i, j]}\t"); // \t = 4 пробела между эл
        }
        Console.WriteLine();
    }
}

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.

// int GetMainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             if (i == j) // Номер стр = номер стлбц
//             {
//                 sum += matr[i, j]; // sum = sum + matr[i, j];
//             }
//         }
//     }
//     return sum;
// }


// void SquareElements(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i,j] *= matr[i,j]; // matr[i,j] = matr[i,j] * matr[i,j];
//             }
//         }
//     }
// }

// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 
// double[] GetArrayWithMeans(int[,] matr)
// {
//     double[] means = new double[matr.GetLength(0)];
//     for (int i = 0; i < matr.GetLength(0); i++)// цикл по стрч
//     {
//         double currentSum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)// цикл по cтолб
//         {
//             currentSum += matr[i, j];
//         }
//         means[i] = Math.Round(currentSum / matr.GetLength(1), 2);
//     }
//     return means;
// }



// // Вызов функции 
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] res = CreateMatrix(rows, columns);
// PrintMatrix(res); // Матрица ДО
// // Console.WriteLine("Результат: ");
// // SquareElements(res); // Возведение в квадрат эл. 
// // PrintMatrix(res); // Матрица ПОСЛЕ
// // Console.WriteLine($"Total: {GetMainDiagonalSum(res)}");
// Console.WriteLine($"Result: [ {string.Join("; ", GetArrayWithMeans(res))} ]");

// ДЗ

