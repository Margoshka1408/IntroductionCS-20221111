// Задача Гиа про учеников

int n=Convert.ToInt32(Console.ReadLine());
int k=0;// счетчик
bool flag=false;//флаг
for(int i=0;i<n;i++)
{
int a=Convert.ToInt32(Console.ReadLine());
if (a<5) k++;
if (a==10) flag=true;
}
System.Console.WriteLine(k);
if (flag) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");