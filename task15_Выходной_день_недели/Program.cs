/*
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

System.Console.WriteLine("Введите число 1-7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 7 || dayNumber < 1)
{
    System.Console.WriteLine("Ошибка");
}
else if (dayNumber < 6)
{
    System.Console.WriteLine($"{dayNumber} -> Будний");
}
else if (dayNumber > 5)
{
    System.Console.WriteLine($"{dayNumber} -> Выходной день");
}