//string -класс,ссылочный тип
//immutable string - неизменяемые строки
//ReadLn(a,b,c)
//10 20 30
/*string s=Console.ReadLine();//вводим строку
string[] ss=s.Split(' ');//разбиваем
int[] n=new int[ss.Length];//создаем массив
for(int i=0;i<ss.Length;i++)//цикл,где пробегаемся по массиву
  n[i]=Convert.ToInt32(ss[i]);//конвертируем каждый элемент
int a=n[0];
int b=n[1];
int c=n[2];
*/

string[] ss=Console.ReadLine().Split(' ');//сразу создаем массив
int[] n=Array.ConvertAll<string,int>(ss,Convert.ToInt32);//обобщенные типы и параметризированные методы
int a=n[0];
int b=n[1];
int c=n[2];


/*
string s="asdf";
System.Console.WriteLine(s[0]);
for(int i=0;i<s.Length;i++)
System.Console.WriteLine(s[i]);
char[] cc=s.ToCharArray();
cc[0]='s';
s=new String(cc);
System.Text.StringBuilder sb=new System.Text.StringBuilder("asda");//когда очень много срок
sb[0]='s';
s=sb.ToString();
//for(int i=0;i<1000;i++)
//sb=sb+"1";//создается новая строка
for(int i=0;i<1000;i++)
sb.Append("1");//создается новая строка
*/

/*
string s1="Hello";
string s2="Hello";
System.Console.WriteLine(s1==s2);//стравниваем строки.содержимое
System.Console.WriteLine(s1.CompareTo(s2));//другой способ сравнения
System.Console.WriteLine(String.Compare(s1,s2));//еще способ сравнения//compare возвращает int

Random random1=new Random();
Random random2=new Random();
random2=random1;
System.Console.WriteLine(random1==random2);//сравниваем объекты.адреса
//s1.Length-длина строки
//s2=s1.Sunstring(2,3)-получить подстроку,со второй строки 3 символа
//System.Console.WriteLine(s1.IndexOf("as"));//совпадение символов
//s2=s1.Replace('a','b');//поменять символы
*/




