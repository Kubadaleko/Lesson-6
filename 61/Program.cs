// 61.Показать двумерный массив размером m×n заполненный
// вещественными случайными числами

void PrintArry(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
}

double[,] matrix = new double[3, 4];

FillArray(matrix);
System.Console.WriteLine();
PrintArry(matrix);