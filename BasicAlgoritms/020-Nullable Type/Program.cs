Nullable<int> b;
int? a=0;
//a=null; ссылается на пустоту
System.Console.WriteLine(a.HasValue+" "+a.Value);

int? Test()
{
    return null;
}

string? s;
s=null;