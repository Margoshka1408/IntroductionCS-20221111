// алгоритм Евклида

int GCD(int a,int b)
{
    while(a!=b)
if (a>b)
a=a-b;
else b=b-a;
return a;
}
System.Console.WriteLine(GCD(15,20));
