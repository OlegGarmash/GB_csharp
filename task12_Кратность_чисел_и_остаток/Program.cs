/*
Напишите программу, которая принмает на вход два числа
и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
*/

System.Console.WriteLine("Введите число 1: ");
int userNumberOne = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: ");
int userNumberTwo = Convert.ToInt32(Console.ReadLine());

if (userNumberOne % userNumberTwo == 0)
{
    System.Console.WriteLine($"{userNumberOne}, {userNumberTwo} -> кратно");
}
else
{
    int result = userNumberOne % userNumberTwo;
    System.Console.WriteLine($"{userNumberOne}, {userNumberTwo} -> некратно, остаток {result}");
}