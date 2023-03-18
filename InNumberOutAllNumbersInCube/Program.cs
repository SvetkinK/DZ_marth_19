// На вход число N, на выход таблица кубов чисео от 1 до N
void NumbersInCube(int n)
{
  int b = 0;
  for (int i = 1; i <= n; i++)
  {
    b = i * i * i;
    Console.Write($"{b}, ");
  }
}

Console.Write("введите число ");
int n = Convert.ToInt32(Console.ReadLine());
NumbersInCube(n);