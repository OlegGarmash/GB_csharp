/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int IntN(int m, int n)
{
    if (n > m)
        return m + IntN(m+1, n);
    else
        return m;
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");
int result = IntN(m, n);

System.Console.WriteLine(result);