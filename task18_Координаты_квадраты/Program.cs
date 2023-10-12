/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

System.Console.WriteLine("Введите четверть:");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter > 0 && quarter < 5)
{
    if (quarter == 1)
        System.Console.WriteLine("X = [1..n], Y [1..m]");
    else if (quarter == 2)
        System.Console.WriteLine("X = [-1..-n], Y = [1..m]");
    else if (quarter == 3)
        System.Console.WriteLine("X = [-1..-n], Y = [-1..-m]");
    else if (quarter == 4)
        System.Console.WriteLine("X = [1..n], Y = [-1..-m]");
}
else
    System.Console.WriteLine("Error");