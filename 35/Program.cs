//35.Написать программу замены элементов массива на противоположные

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " "); 
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    array[j] = array[j] * -1;
    Console.Write(array[j]+ " ");
}