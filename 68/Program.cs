//68.Написать программу, которая обменивает элементы первой строки и последней строки


int[,] a = new int[5, 5];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().Next(1, 20);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
int m = 0;
for (int i = 0; i < a.GetLength(1); i++)
{
    m = a[a.GetLength(0) - 1, i];
    a[a.GetLength(0) - 1, i] = a[0, i];
    a[0, i] = m;
}
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}


