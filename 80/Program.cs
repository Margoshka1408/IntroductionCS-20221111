//80.Вывести на экран кодировку символов по ASCII(с 32 до 122)

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
    Console.WriteLine(i.ToString() + "-й символ таблицы ASCII: " + (char)i);
System.Console.WriteLine();
