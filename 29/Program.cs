//29.Подсчитать сумму цифр в числе. Сделать подпрограмму.

// подпрограмма
int CountDigits(int Number)

{
Number=Math.Abs(Number);
int res=0;
if (Number==0) res=0;
while (Number>0)
{
    res=res + Number%10;
    Number=Number/10;
}
return res;
}
//основная программа
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CountDigits(N));
