// 62.В двумерном массиве n×k заменить четные элементы на
// противоположные по значению (a[i,j]=-a[i,j]). Написать отдельную
// подпрограмму на вход которой подается массив, а на выходе
// измененный массив.

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
            if (modified[i, j] % 2 == 0)
                modified[i, j] = -modified[i, j];
        }
    }
}


int[,] matrix = new int[5, 6];

FillArray(matrix);
PrintArry(matrix);
System.Console.WriteLine();
ModifiedArray(matrix);
PrintArry(matrix);

