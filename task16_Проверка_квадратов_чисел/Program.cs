/*
Напишите программу, которая принимает на хвод два числа и 
проверяет, является ли одно число квадратом другого.
*/

System.Console.WriteLine("Введите число 1: ");
int userNumberOne = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int userNumberTwo = Convert.ToInt32(Console.ReadLine());

if (userNumberOne == userNumberTwo * userNumberTwo || userNumberTwo == userNumberOne * userNumberOne)
{
    System.Console.WriteLine($"{userNumberOne}, {userNumberTwo} -> да");
}
else
{
    System.Console.WriteLine($"{userNumberOne}, {userNumberTwo} -> нет");
}