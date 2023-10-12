/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
*/

System.Console.WriteLine("Введите координату X1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(x2 - x1, 2);
double squareY = Math.Pow(y2 - y1, 2);
double squareZ = Math.Pow(z2 - z1, 2);

double result = Math.Round(Math.Sqrt(squareX + squareY + squareZ), 2);

System.Console.WriteLine(result);