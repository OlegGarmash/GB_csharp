/*
Напишите программу, которая выводит третью цифру заданного числа или
сообщает, что третьей цифры нет.
*/

System.Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    System.Console.WriteLine($"{number} -> третьей цифры нет");
else
{
    int i = number;
    while (i > 999)
    {
        i = i / 10;
    }
    int result = i % 10;
    System.Console.WriteLine($"{number} -> {result}");
}