﻿//26.Найти сумму чисел от 1 до А

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = A * (A + 1) / 2;

Console.WriteLine("Сумма чисел от 1 до " + A + " равна: " + sum);
