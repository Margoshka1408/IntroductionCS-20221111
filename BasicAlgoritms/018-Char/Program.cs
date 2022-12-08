char c='a';//char хранит в себе символ,char -структура
c='\x64';
c='\u0064';
char b='a';
System.Console.WriteLine((int)b);//приведение типа
System.Console.WriteLine(c.ToString()+b.ToString());//склейка двух символов
if (b>='0' && b<='9') System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");//является ли буквой латинского алфавита
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");