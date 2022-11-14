//12.С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int N= Convert.ToInt32(Console.ReadLine());
int Max=0;

int DigitOne = N / 10;
    int DigitTwo = N % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

System.Console.WriteLine($"В числе {N} наибольшая цифра {Max}");

