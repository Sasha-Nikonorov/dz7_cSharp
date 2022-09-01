void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j].ToString("F2")}, ");
        }
        Console.WriteLine();
    }
}

double[,] CreateArrayWithRandomNumbers(int m, int n)
{
    double[,] result = new double[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.NextDouble() * 10 - random.Next(1, 10);
        }
    }

    return result;
}

int ReadInputData()
{
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

Console.WriteLine("Введите число строк (m)");
int numberOfRows = ReadInputData();

Console.WriteLine("Введите число столбцов (n)");
int numberOfColumns = ReadInputData();


PrintArray(CreateArrayWithRandomNumbers(numberOfRows, numberOfColumns));
