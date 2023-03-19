// На вход число любой разрядности, проверить является ли оно палиндромным
//(смогла только максимальной разрядности 9 элементов, если элементов 10 и больше - не работает((. )
int DigitNumber(string a)          //разрядность
{
int c = 10;
int dig = c;
for(int i = 1; i < a.Length; i++)
{
  dig= dig*c;
}
dig = dig/10;
return dig;
}
int Number(string digit)           //кол-во элементов
{
  int c = digit.Length;
  return c;
}


Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int digit = DigitNumber($"{N}");
//Console.WriteLine($"разрядность = {digit}");
int length = Number($"{digit}");
//Console.WriteLine($"кол-во элементов = {length}");

int i = 1;
int rev = 0;
int b = 0;
int c = 1;
while(i <= length)
{
b = digit*(N/c - N/(c*10) * 10);
digit = digit/10;
c=c*10;
rev = rev + b;
i++;
}

if(N==rev) Console.WriteLine($"{N} -> палиндром");
else Console.WriteLine($"{N} -> не палиндром");

//Console.WriteLine($"реверсное = {rev}");
