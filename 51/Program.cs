//51.С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int[] RandomIntArray(int N, int min, int max)
{
    int[] a=new int[N];
//заполнили массив
Random random=new Random();
for(int i=0;i<a.Length;i++)
     a[i]=random.Next(-100,200);
return a;     
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
    System.Console.Write(formatString,a[i]);
}

void BubbleSort(int[]a,out int count)
{
    count=0;
    for(int i=0;i<a.Length;i++)
      
        if(a[i]>0)
        count++;
}
    

int[] a=RandomIntArray(10,0,10);
PrintArray(a);
int count=0;
BubbleSort(a,out count);
System.Console.WriteLine();
System.Console.WriteLine(count);
