/*
Напишите программу, которая принимает на вход число(N) и 
выдаёт таблицу квадратов чисел от 1 до N.
*/

System.Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numberN + 1; i++)
{
    System.Console.WriteLine(Math.Pow(i, 2));
}