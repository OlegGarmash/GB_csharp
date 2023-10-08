/*
1. Напишите программу, которая на вход принимает два числа и проверяет,
является ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

System.Console.WriteLine("Введите число 1: ");
int userNumberOne = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int userNumberTwo = Convert.ToInt32(Console.ReadLine());

if (userNumberOne == userNumberTwo * userNumberTwo)
    {
        System.Console.WriteLine("Является корнем");
    }
    else 
    {
        System.Console.WriteLine("Не явлется корнем");
    }

