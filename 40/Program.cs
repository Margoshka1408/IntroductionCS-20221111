// 40. Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int N = 10;
int[] a = new int[N];

for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(0, 10);
    Console.Write(a[i] + " ");
}
Console.WriteLine();

int j = a.Length - 1;
for (int i = 0; i < (a.Length + 1) / 2; i++)
{
    Console.Write(a[i] * a[j] + " ");
    j--;
}