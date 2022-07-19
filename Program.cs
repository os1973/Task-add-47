/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,19
*/

int[,] InitMatrix(int m, int n)
{
    int[,]matrix = new int [m,n]
    Random randomizer = new Random();

    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            matrix[i,j] = randomizer.NextDouble(new Random);
        }
    }
    return matrix;
}

void PrintMatrix(int[,]matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
        Console.Write(${matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m: ");
Console.ReadLine();
Console.WriteLine("Введите число n: ");
Console.ReadLine():

int[,]matrix = InitMatrix(m,n);

Console.WriteLine($"Матрица размером {m}*{n}: ");
Console.WriteLine();

PrintMatrix(matrix);
