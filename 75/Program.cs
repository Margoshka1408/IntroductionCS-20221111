//75.Написать программу вычисления функции Аккермана - 5*

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if(m>0 && n==0)
    {
        return Akk(m-1,1);
    }
    else if (m>0 && n>0)
    {
        return Akk(m-1,Akk(m,n-1));
    }
    else return Akk(m,n);
}
Console.WriteLine(Akk(3,4));