/*
Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

void IntN(int m, int n)
{
    if (n >= m)
    {
        System.Console.Write(m + " ");
        IntN(m + 1, n);
    }
    else return;
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");
IntN(m, n);