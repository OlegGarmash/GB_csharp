/*
Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);

//Метод 1
int first = number / 100;
int last = number % 10;

System.Console.WriteLine($"{number} -> {first}{last}");

//Метод 2
int result = first * 10 + last;

System.Console.WriteLine($"{number} -> {result}");