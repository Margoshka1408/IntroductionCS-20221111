//27.Возведите число А в натуральную степень B используя цикл

int A = 2;
int B = 10;
int count = 1;
int result = A;

while (count < B)
{
    result = result * A;
    count++;
}

System.Console.WriteLine($"{A} ^ {B} = {result}");
System.Console.WriteLine();
