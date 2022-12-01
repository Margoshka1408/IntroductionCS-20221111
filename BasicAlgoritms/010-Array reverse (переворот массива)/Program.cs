//38.В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]// переворот массива

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

void Reverse(int [] a)//ref 
{
    for(int i=0;i<a.Length/2;i++)
       Swap(ref a[i],ref a[a.Length-1-i]);//a.Length-1-i последний элемент
}
//создали массив
int N=10;
int[] a=RandomIntArray(N,0,200);
PrintArray(a,5);

//обработка массива
//a.Reverse()
a=a.Reverse().ToArray();//возвращает инструкции по перевороту массива
System.Console.WriteLine();
PrintArray(a,5);
