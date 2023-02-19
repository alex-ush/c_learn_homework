// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату точки A x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки A y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки A z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату точки B x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки B y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату точки B z2: ");
int z2 = int.Parse(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine("Расстояние между точками A и B: " + Math.Round(distans, 2));
