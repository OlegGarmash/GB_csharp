/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int number = new Random().Next(10, 100);

int first = number / 10;
int last = number % 10;

if (first > last)
    System.Console.WriteLine($"{number} -> {first}");
else
    System.Console.WriteLine($"{number} -> {last}");