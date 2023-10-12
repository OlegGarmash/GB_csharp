/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

System.Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
        System.Console.WriteLine("Первая четверть");
    else if (x < 0 && y > 0)
        System.Console.WriteLine("Вторая четверть");
    else if (x < 0 && y < 0)
        System.Console.WriteLine("Третья четверть");
    else if (x > 0 && y < 0)
        System.Console.WriteLine("Чётвертая четверть");
}
else
    System.Console.WriteLine("Координаты не соотвествуют ТЗ");