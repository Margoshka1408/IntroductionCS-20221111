void Swap(ref int a,ref int b)//reference-ссылка
{
    int t=a;
    a=b;
    b=t;
}
void Calculator(int a,int b, out int sum,out int multi)//out можно не присваивать значения
{
    sum=a+b;
    multi=a*b;
}

int a=3,b=5;
System.Console.WriteLine($"a={a} b={b}");
Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");
int sum,multi;//описываем переменные, в которые будут возвращаться значения
Calculator(a,b,out sum,out multi);

bool flag;
int x;
do
{
flag=int.TryParse(Console.ReadLine(),out x);// TryParse не выдаст исключительную ситуацию
if (flag==false) System.Console.WriteLine("Введете целое число!");
}
while(flag==false);