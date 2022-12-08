//87. Удалить среднюю букву при нечетное длине строки и две средние буквы при четной длине строки
string s=Console.ReadLine();
string s1;
int m=s.Length/2;//середина строки
if (s.Length%2==0)
{
    s1=s.Remove(m-1,2);//удаляем 2 символа
}
else
{
    s1=s.Remove(m,1);
}
System.Console.WriteLine(s1);
