/*
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
*/

double[] GetArray()
{
    string[] dots = { "b1", "k1", "b2", "k2" };
    double[] array = new double[dots.Length];

    for (int i = 0; i < dots.Length; i++)
    {
        System.Console.Write($"Введите значение {dots[i]}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double GetX(double[] array)
{
    return Math.Round((array[0] - array[2]) / (array[3] - array[1]), 2);
}

double GetY(double[] array)
{
    return Math.Round(array[1] * GetX(array) + array[0], 2);
}

void PrintArray(double[] arrayOne)
{
    string[] dots = { "b1", "k1", "b2", "k2" };
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write($"{dots[i]} = {arrayOne[i]}");
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    Console.ResetColor();
    System.Console.Write(" -> ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine($"({GetX(arrayOne)}; {GetY(arrayOne)})");
    Console.ResetColor();
}

PrintArray(GetArray());