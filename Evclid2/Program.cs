// ускоренный алгоритм Евклида

int k=0;
int GCD(int a,int b)
{
    while(a!=b && b!=a)
    {
        k++;
        if (a>b)
            a=a-b;
    else b=b-a;
    }
return a+b;
}

int QuicGCD(int a,int b)
{
    while(a!=0 && b!=0)
    {
        k++;
        if (a>b)
            a=a%b;
    else b=b%a;
    }
return a+b;
}
System.Console.WriteLine(GCD(1,2000));
System.Console.WriteLine(k);
k=0;
System.Console.WriteLine(QuicGCD(1,2000));
System.Console.WriteLine(k);

