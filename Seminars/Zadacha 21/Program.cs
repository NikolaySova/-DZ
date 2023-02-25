// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координаты точки X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координаты точки Z2: ");
double Z2 = Convert.ToDouble(Console.ReadLine()!);

double x = Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2);

double len = Math.Sqrt(x);

Console.WriteLine($"Расстояние между двумя точками равна {len:f2}");