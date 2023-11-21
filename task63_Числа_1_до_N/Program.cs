/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

void IntN(int n, int current = 1)
{
    if (n >= current)
    {
        System.Console.Write(current + " ");
        IntN(n, current + 1);
    }
    else return;
}

int n = Prompt("Введите число N: ");
IntN(n);