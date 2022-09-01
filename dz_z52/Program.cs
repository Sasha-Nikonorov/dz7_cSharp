﻿void PrintArray1(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}
// комментарии оставлены, чтобы попробовать позже заменить вывод ответа через одномерный масив

// void PrintArray2(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i].ToString("F2")}");
//         if (i == arr.Length - 1) Console.Write("");
//         else Console.Write(", ");
//     }
// }

int ReadInputData()
{
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}

void ArithmeticMean(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double result = sum / array.GetLength(0);
        Console.Write($"{result.ToString("F2")} ");
    }
}

// double[] ArithmeticMean(int[,] array)
// {
//     double sum = 0;
//     double[] result = new double[array.GetLength(0)];
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             sum += array[i, j];
//         }
//         result[j] = sum / array.GetLength(1);
//         sum = 0;
//     }
//     return result;
// }

Console.WriteLine("Введите число строк (m)");
int numberOfRows = ReadInputData();

Console.WriteLine("Введите число столбцов (n)");
int numberOfColumns = ReadInputData();

var array = CreateArrayWithRandomNumbers(numberOfRows, numberOfColumns);
PrintArray1(array);
Console.WriteLine();
ArithmeticMean(array);
// var arr = ArithmeticMean(array);
// PrintArray2(arr);