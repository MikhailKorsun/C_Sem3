//21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21;

int[] a = new int[2];
int[] b = new int[2];
Console.WriteLine("Введите координаты точки А: ");
Console.Write("xA = ");
a[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("yA = ");
a[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("xB = ");
b[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("yB = ");
b[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({a[0]},{a[1]}), B({b[0]},{b[1]})");

double distance = Math.Round(Math.Sqrt(Math.Pow((b[0]-a[0]),2) + Math.Pow((b[1]-a[1]),2)), 2);
Console.WriteLine($"Расстояние между точками A и B = {distance}");