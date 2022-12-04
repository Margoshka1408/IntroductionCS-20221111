//67.Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] Random2DArray(int n,int m)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
       for(int j=0;j<m;j++)
         a[i,j]=random.Next(0, 20);
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
string ArithmeticMean(int[,] a)
{
    string result = string.Empty;
    for (int n = 0; n < a.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < a.GetLength(0); m++)
        {
            sum += a[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
}

int[,] a = Random2DArray(6,6);

Print2DArray(a);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(a));