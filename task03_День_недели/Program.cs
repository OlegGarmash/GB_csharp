/* 
3. Напишите программу, которая будет выдавать названия дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите число 1-7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (dayNumber == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (dayNumber == 3)
{
    System.Console.WriteLine("Среда");
}
else if (dayNumber == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (dayNumber == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (dayNumber == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (dayNumber == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Ошибка");
}
