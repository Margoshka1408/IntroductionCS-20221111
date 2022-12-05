//Вывести числа от 1 до N без использования цикла
//рекурсия-сами себя вызываем
/*
int i=1;
int N=10;
metka:
    System.Console.WriteLine(i);
    i++;
    if (i<=N) goto metka;
*/

void Loop(int N,int i)
{
    if (i<=N)
    {
        System.Console.WriteLine(i);
        Loop(N,i+1);// снова обращаемся к подпрограмме
    }
}
Loop(10,1);