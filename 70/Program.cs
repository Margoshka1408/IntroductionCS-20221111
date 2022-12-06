//70.Показать натуральные числа от 1 до N, N задано

void Loop(int N)
{
    if (N<1) return;
        Loop(N-1);
        System.Console.WriteLine(N+" ");
}
Loop(10);