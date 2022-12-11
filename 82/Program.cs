//82.C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s=Console.ReadLine();
int k=0;
char tochka = '.';
for(int i = 0; i < s.Length; i++) 
{
    if(!s[i].Equals(tochka)) k++;
    else break;
}
System.Console.WriteLine(k);

