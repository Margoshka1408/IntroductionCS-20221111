//17.Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int n=Convert.ToInt32(Console.ReadLine());
if (n==6 || n==7) System.Console.WriteLine("Выходной"); else System.Console.WriteLine("Рабочий");