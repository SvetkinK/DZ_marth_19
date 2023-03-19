// На вход координаты двух точек, на выход расстояние между ними в n-мерном пространстве
//Сначала задать n, затем задать координаты точек

Console.Write("Введите мерность пространства ");
int n = Convert.ToInt32(Console.ReadLine());

int [] point1 = new int [n];
for(int index = 0; index < n; index++)
{
  Console.Write("Введите координаты точки 1 ");
  point1[index] = Convert.ToInt32(Console.ReadLine());
}

int [] point2 = new int [n];
for(int index = 0; index < n; index++)
{
  Console.Write("Введите координаты точки 2 ");
  point2[index] = Convert.ToInt32(Console.ReadLine());
}

double dist = 0;
for(int index = 0; index < n; index++)
{
  dist = dist + (point1[index]-point2[index])*(point1[index]-point2[index]);
}
dist = Math.Sqrt(dist);
Console.WriteLine(dist);