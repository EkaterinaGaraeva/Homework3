/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты точки А");
Console.Write("Xa = ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya = ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Za = ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В");
Console.Write("Xb = ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb = ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb = ");
int Zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) 
+ (Za - Zb) * (Za - Zb));
result = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками: {result}");
