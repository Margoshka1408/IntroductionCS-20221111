//64.В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.


int[,] Random2DArray(int n,int k,int min=0,int max=10)
{
    int[,] a=new int[n,k];
    Random random=new Random();
    for(int i=0;i<n;i++)
       for(int j=0;j<k;j++)
         a[i,j]=random.Next(min,max+1);
    return a;
}
void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)      
            System.Console.Write($"{a[i,j],4}");
               System.Console.WriteLine();
    }
}

void ReplaceArray(int[,] a)
{
    for (int n = 0; n < a.GetLength(0); n++)
    {
        for (int k = 0; k < a.GetLength(1); k++)
        {   if ((n % 2 == 0) && (k % 2 == 0))
            a[n, k] =a[n, k]*a[n, k];
        }
    }
}
int [,] a=Random2DArray(5,7);
Print2DArray(a);
System.Console.WriteLine();
ReplaceArray(a);
Print2DArray(a);
