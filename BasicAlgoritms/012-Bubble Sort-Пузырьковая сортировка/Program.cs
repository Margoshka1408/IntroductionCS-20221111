//Bubble Sort (Пузырьковая сортировка)
//1
/*
int[] RandomIntArray(int N, int min, int max)
{
    int[] a=new int[N];
//заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
     a[i]=random.Next(0,200);
return a;     
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
    System.Console.Write(formatString,a[i]);
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[]a)
{
    for(int i=0;i<a.Length;i++)
      for(int j=0;j<a.Length-1;j++)
        if(a[j]>a[j+1])
        Swap(ref a[j],ref a[j+1]);
}
    

int[] a=RandomIntArray(10,0,10);
PrintArray(a);
BubbleSort(a);
System.Console.WriteLine();
PrintArray(a);
*/

//2 подсчитываем количество раз
/*
int[] RandomIntArray(int N, int min, int max)
{
    int[] a=new int[N];
//заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
     a[i]=random.Next(0,200);
return a;     
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
    System.Console.Write(formatString,a[i]);
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[]a,out int count)
{
    count=0;
    for(int i=0;i<a.Length;i++)
      for(int j=0;j<a.Length-1;j++)
        if(a[j]>a[j+1])//сравнение двух соседних элементов
        count++;
}
    

int[] a=RandomIntArray(10,0,10);
PrintArray(a);
int count=0;
BubbleSort(a,out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);*/

//3
int[] RandomIntArray(int N, int min, int max)
{
    int[] a=new int[N];
//заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
     a[i]=random.Next(0,200);
return a;     
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
    System.Console.Write(formatString,a[i]);
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void BubbleSort(int[] a,out int count)
{
    count=0;
    int flag=0;
    for(int i=0;i<a.Length;i++)
    {
        flag=0;
        for(int j=0;j<a.Length-1-i;j++)
        {
            if (a[j]>a[j+1])
            {
              Swap(ref a[j],ref a[j+1]);
              flag=1;
            }
            count++;
        }
        if (flag==0) return;
    }
}

int[] a=RandomIntArray(100,0,10);
PrintArray(a);
int count=0;
BubbleSort(a,out count);
System.Console.WriteLine();
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(count);