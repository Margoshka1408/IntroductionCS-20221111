//61.Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArray(double n,double m)
{
    double[,] a=new double[5,4];
    Random random=new Random();
    for(int i=0;i<n;i++)
       for(int j=0;j<m;j++)
         a[i,j]=new Random().NextDouble();
    return a;
}
void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++)      
            System.Console.Write($"{a[i,j],4}");
               System.Console.WriteLine();
    }
}
double [,] a=Random2DArray(5,4);
Print2DArray(a);

