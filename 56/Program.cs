//56.Написать программу копирования массива

int[] RandomIntArray(int N, int min, int max)
{
    int[] a=new int[N];

Random random=new Random();
for(int i=0;i<a.Length;i++)
     a[i]=random.Next(0,200);
return a;     
}

int[] array = new int[10];
int arrayCopy;

Console.Write("Оригинал ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 50);
    Console.Write (array [i] + " ");
}
Console.WriteLine();
array[2] = 17; 
Console.Write(" Копия ");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
}


