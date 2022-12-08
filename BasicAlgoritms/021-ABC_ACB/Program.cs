//ABC=>CAB, ABC=>CBA

bool Test(string s1,string s2)
{
    s1=s1.ToLower();
    s2=s2.ToLower();
    if (s1.Length!=s2.Length) return false;//сравниваем
    char[] c1=s1.ToCharArray();//преобразуем
    char[] c2=s2.ToCharArray();
    Array.Sort(c1);//ABC сортировка
    Array.Sort(c2);//ABC
    s1=new String(c1);//обратно собираем
    s2=new String(c2);
    return s1==s2;//возвращаем равенство строк
}

string s1="ABcDe";
string s2="EDbCa";

System.Console.WriteLine(Test(s1,s2));
