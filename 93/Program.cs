//93.Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и
//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

void FillArray(int[,] matr1, int[,] matr2)
{
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++);
    }

    for (int m = 0; m < matr2.GetLength(0); m++)
    {
        for (int n = 0; n < matr2.GetLength(1); n++);
    }
}

void PrintArray(int[,] matr1, int[,] matr2)
{
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            Console.Write($"{matr1[m,n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < matr2.GetLength(0); m++)
    {
        for (int n = 0; n < matr2.GetLength(1); n++)
        {
            Console.Write($"{matr2[m,n]} ");
        }
        Console.WriteLine();
    }
}

void  Composition(int[,] matr1, int[,] matr2, int[,] compMatr)
{
    for (int m = 0; m < matr1.GetLength(0); m++)
    {
        for (int n = 0; n < matr1.GetLength(1); n++)
        {
            compMatr[m, n] = matr1[m, n] * matr2[m, n];
        }
    }
}

void PrintCompArray(int[,] compMatr)
{
    for (int m = 0; m < compMatr.GetLength(0); m++)
    {
        for (int n = 0; n < compMatr.GetLength(1); n++)
        {
            Console.Write($"{compMatr[m,n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix1 = new int[4, 4]{{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}};
int[,] matrix2 = new int[4, 4]{{1,5,8,5},{4,9,4,2},{7,2,2,6},{2,3,4,7}};
int[,] compMatrix = new int[4, 4];
FillArray(matrix1, matrix2);
PrintArray(matrix1, matrix2);
Console.WriteLine();
Composition (matrix1, matrix2, compMatrix);
PrintCompArray(compMatrix);

