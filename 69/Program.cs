//  69. Написать программу, упорядочивания по убыванию 
//  элементы каждой строки двумерной массива.

int[,] matrix = { { 5, 8, 9, 14 }, { 8, 5, 2, 1 }, { 9, 6, 7, 2 } };


void Print2DArray(int[,] a)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write($"{matrix[i, j]} ");
        System.Console.WriteLine();
    }
}

void Sort2DArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int k = 0; k < a.GetLength(0); k++)
            for (int j = 0; j < a.GetLength(1) - 1; j++)
                if (a[i, j] < a[i, j + 1])
                {
                    int t = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = t;
                }
}
Print2DArray(matrix);
System.Console.WriteLine();
Sort2DArray(matrix);
Print2DArray(matrix);
