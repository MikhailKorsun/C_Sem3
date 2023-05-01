// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А: ");
Console.Write("xA = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA = ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("zA = ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("xB = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("yB = ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("zB = ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({xA},{yA},{zA}), B({xB},{yB},{zB})");
double distance = Math.Round(Math.Sqrt(Math.Pow((xB-xA),2) + Math.Pow((yB-yA),2) + Math.Pow((zB-zA),2)), 2);
Console.WriteLine($"Расстояние между точками A и B = {distance}");