/*
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
*/

System.Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 || number < 100000)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
        System.Console.WriteLine($"{number} -> True");
    else
        System.Console.WriteLine($"{number} -> False");
}
else
    System.Console.WriteLine($"{number} -> Число не пятизначное");