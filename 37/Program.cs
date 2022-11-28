//37.Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a = new int[10];
int countEven = 0;
int countNotEven = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(100, 999);
    Console.Write(a[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < a.Length; j++)
{
    if (a[j] % 2 == 0) countEven = countEven + 1;
    else countNotEven = countNotEven + 1;
}
Console.Write("Четные числа : " + countEven);
Console.WriteLine();
Console.Write("Нечетные числа : " + countNotEven);
