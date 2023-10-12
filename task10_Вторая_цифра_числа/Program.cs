/*
Напишите программу, которая принимает на вход трёхзначное число и
на выходе показывает вторую цифру числа.
*/

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 10 % 10;
System.Console.WriteLine($"{number} -> {result}");