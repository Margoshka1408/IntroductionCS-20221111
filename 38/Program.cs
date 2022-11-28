//38.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int N, int min, int max)
{
    int[] a=new int[N];
//заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
     a[i]=random.Next(0,200);
return a;     
}

void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}");
}
int Solve(int[] a)
{
     //foreach для каждого
int count=0;
foreach(int el in a)//какая-то переменная в какой-то коллекции
{   if(el>=10 && el<=99)
        count++; 
}
return count;        
}
//создали массив
int N=123;
int[] a=RandomIntArray(N,0,200);
PrintArray(a);

//обработка массива
      
System.Console.WriteLine($"\n{Solve(a)}"); //переход на след строчку








 /*  способ 2 без подпрограмм
//создали массив
int N=123;
int[] a=new int[N];
//заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(0,200);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],5}");
//обработка массива
int count=0;
for(int i=0;i<a.Length;i++)
if(a[i]>=10 && a[i]<=99)
count++;
System.Console.WriteLine();
System.Console.WriteLine(count);
*/
