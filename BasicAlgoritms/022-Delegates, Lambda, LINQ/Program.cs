//89. Подсчитать сумму цифр, встречающихся в строке

//Делегаты
/*
int CountDigits(string s)//подсчитали количество цифр в строке
 {
   int count=0;
    foreach(char c in s)
    if (char.IsDigit(c))
      count++;
    return count;
 }
*/
/*
int CountLatin(string s)//подсчитали количество латинских букв в строке
 {
   int count=0;
    foreach(char c in s)
    if (c>='A' && c<='Z' || c>='a' && c<='z')//диапазон
      count++;
    return count;
 }
 */

/*
 int CountRus(string s)//подсчитали количество латинских букв в строке
 {
   int count=0;
    foreach(char c in s)
    if (c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё')//диапазон букву ё рассматривают отдельно
      count++;
    return count;
 }
 */

 delegate bool IsChar(char c);//сигнатура функции bool(char)
 class Program
{
    /*
     static int CountChars(string s, IsChar isChar)
     {
         int count=0;
        foreach(char c in s)
             if (isChar(c))
                 count++;
        return count;
     }
    */
        static int CountChars(string s, Func<char,bool> isChar)//на вход char на выходе bool
    {
        int count=0;
        foreach(char c in s)
            if (isChar(c))
                count++;
        return count;
    }

    static bool IsLatin(char c)
    {
        return (c>='A' && c<='Z' || c>='a' && c<='z');
    }

    static  bool IsRus(char c)
    {
        return (c>='А' && c<='Я' || c>='а' && c<='я' || c=='Ё' || c=='ё');
    }

    static void Main()
    {
        string s="Эта строка содержит latinskie буквы и цифры(12345)";
        System.Console.WriteLine(CountChars(s,IsLatin));
        System.Console.WriteLine(CountChars(s,IsRus));
    }
}
/*
//Action click
click=new Action(выделение)
click=new Action(заливка)
//Func готовый делегат
*/


/*
        System.Console.WriteLine(CountChars(s,IsLatin));
        System.Console.WriteLine(CountChars(s,delegate(char c)//анонимный делегат,
        внутри вызова какого-то метода взять и описать какую-то функцию
        {
            return (c>='A' && c<='Z' || c>='a' && c<='z');
        }
        ));
        
        System.Console.WriteLine(CountChars(s,
        (c)=>//лямбда-выражение многострочное
        {
            return (c>='A' && c<='Z' || c>='a' && c<='z');
        }
        ));
        System.Console.WriteLine(CountChars(s,
        (c)=>c>='A' && c<='Z' || c>='a' && c<='z'
        //лямбда-выражение однострочное
        ));
        System.Console.WriteLine(CountChars(s,IsRus));
        System.Console.WriteLine(CountChars(s,char.IsDigit));
        //=> Лямбда выражения
        */

        /*
        using System.Linq; язык в языке
        string s="asd123";
        var queary=(from c in s where (c>='A' && c<='Z' || c>='a' && c<='z') select c).Count();//запрос из строки.набор действий
        var sum=(from c in s where char.IsDigit(c) select char.GetNumericValue(c)).Sum();
        System.Console.WriteLine(sum);
        string s1;
        */