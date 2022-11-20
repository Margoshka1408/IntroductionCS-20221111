//22.Программа проверяет пятизначное число на палиндромом.

int a=Convert.ToInt32(Console.ReadLine());
if(a%10==a/10000 && a/10%10==a/1000%10) System.Console.WriteLine($"{a} является палиндромом"); else System.Console.WriteLine("NO");
