//71.Показать натуральные числа от N до 1, N задано

void Loop(int N)
{
    if (N<1) return;
        System.Console.WriteLine(N+" ");
        Loop(N-1);
}
Loop(10);