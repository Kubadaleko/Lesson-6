// 64. В двумерном массиве заменить элементы, у которых оба индекса чётные 
// на их квадраты по значению.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArry(int[,] array)
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

void ModifiedArray(int[,] modified)
{
    for (int i = 0; i < modified.GetLength(0); i++)
    {
        for (int j = 0; j < modified.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                modified[i, j] = modified[i, j] * modified[i, j];
        }
    }
}


int[,] matrix = new int[2, 3];

FillArray(matrix);
PrintArry(matrix);
System.Console.WriteLine();
ModifiedArray(matrix);
PrintArry(matrix);

