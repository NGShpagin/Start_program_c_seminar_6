// Задача 4: 
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void CopyArray(int[,] matr, int[,] matr_1)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr_1[i, j] = matr[i, j];
        }
    }
}

int[,] matrix = new int[3, 4];
int[,] matrix_1 = new int[3, 4];

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

CopyArray(matrix, matrix_1);
PrintArray(matrix_1);