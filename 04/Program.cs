//4.По заданному с клавиатуры номеру дня недели вывести его название

int a;
System.Console.WriteLine("Введите число");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a==1) System.Console.WriteLine($"{a} понедельник"); 
if (a==2) System.Console.WriteLine($"{a} вторник");
if (a==3) System.Console.WriteLine($"{a} среда");
if (a==4) System.Console.WriteLine($"{a} четверг");
if (a==5) System.Console.WriteLine($"{a} пятница");
if (a==6) System.Console.WriteLine($"{a} суббота");
if (a==7) System.Console.WriteLine($"{a} воскресенье");