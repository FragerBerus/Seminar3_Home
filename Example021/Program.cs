// Задача 21:
// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
Console.Write("Введите координату X первой точки A: ");
double AX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки A: ");
double AY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки A: ");
double AZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки B: ");
double BX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки B: ");
double BY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки B: ");
double BZ = Convert.ToInt32(Console.ReadLine());
double DistanceX = AX - BX;
double DistanceY = AY - BY;
double DistanceZ = AZ - BZ;
double DistanceSqrt = Math.Sqrt((DistanceX * DistanceX) + (DistanceY * DistanceY) + (DistanceZ * DistanceZ));
Console.WriteLine("Расстояние между точками A и B " + DistanceSqrt);