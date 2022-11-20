//20.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

double x=Convert.ToDouble(Console.ReadLine());
double y=Convert.ToDouble(Console.ReadLine());
int quarter=0;

if(x>0 && y>0) quarter=1;
if(x<0 && y>0) quarter=2;
if(x<0 && y<0) quarter=3;
if(x>0 && y<0) quarter=4;
System.Console.WriteLine("quarter:"+quarter);