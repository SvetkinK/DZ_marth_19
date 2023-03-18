// Программа принимает на вход 5-значное число и проверяет, является ли оно палиндромом

void Palindrom(int a, int b)
{
a = new Random().Next(10000,100000);
//a = 57875;
//Console.WriteLine(a);
b = 10000*(a - a/10 * 10) + 1000*(a/10 - a/100 * 10) + 100*(a/100 - a/1000 * 10) + 10*(a/1000 - a/10000 * 10) + (a/10000 - a/100000*10); 
//Console.WriteLine(b);
if(a==b) Console.WriteLine($"{a} -> да");
else Console.WriteLine($"{a} -> нет");
}
int a = 0;
int b = 0;
Palindrom(a, b);


//int[] array = {1,2,3,2,1};
//  void FillArray(int[] fill)
//  {

//    int length = fill.Length;
//    int index = 0;
//    while (index < length)
//    {
//      fill[index] = new Random().Next(1, 10);
//      index++;
//    }
//  }
// void PrintArray(int[] pen)
// {
//   int a = pen.Length;
//   int index = 0;
//   while (index < a)
//   {
//     Console.Write(pen[index]);
//     index++;
//   }
// }
// void FiveDigitPalindrom(int[] pal)
// {
//   int ind = 0;
//   int length = pal.Length;

//   if (pal[ind] == pal[length - 1])
//   {
//     ind = ind + 1;
//     length = length - 1;
//     if (pal[ind] == pal[length - 1])
//     {
//       Console.WriteLine("да");
//     }
//     else
//     {
//       Console.WriteLine("нет");
//     }
//   }
//   else
//   {
//     Console.WriteLine("нет");
//   }
// }

// int[] array = new int [5];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// FiveDigitPalindrom(array);
// Console.WriteLine();
