// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точки А: ");
// Console.Write("xA = ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("yA = ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("zA = ");
// int zA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки B: ");
// Console.Write("xB = ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("yB = ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.Write("zB = ");
// int zB = Convert.ToInt32(Console.ReadLine());

int[] a = new int[3];
int[] b = new int[3];
Console.WriteLine("Введите координаты точки А: ");
Console.Write("xA = ");
a[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("yA = ");
a[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("zA = ");
a[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("xB = ");
b[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("yB = ");
b[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("zB = ");
b[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({a[0]},{a[1]},{a[2]}), B({b[0]},{b[1]},{b[2]})");
double distance = Math.Round(Math.Sqrt(Math.Pow((b[0]-a[0]),2) + Math.Pow((b[1]-a[1]),2) + Math.Pow((b[2]-a[2]),2)), 2);
Console.WriteLine($"Расстояние между точками A и B = {distance}");