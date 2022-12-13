//90.Есть два массива info и data.
//Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
//Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
//Составить массив десятичных представлений чисел массива data с учётом информации из массива info.
//Пример:
//входные данные:
//data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
//info = {2, 3, 3, 1 }
//выходные данные:
//1, 7, 0, 1
//То есть, 2 бита, потом еще 3 бита, потом еще 3 бита и еще 1 бит. Переводим биты в десятичное представление.

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];
int count = 0; 
for (int i = 0; i < info.Length; i++) 
{
    for (int j = 0; j < info[i]; j++)
    {
        Console.Write(data[i + j] + " ");
    }
    i += info[i];
    Console.Write("; ");
}


for (int i = 0; i < info.Length; i++) 
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += data[i + j] * (int)Math.Pow(2, info[i] - 1 - j);
    }
    i += info[i];
}
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}