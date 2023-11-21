/*
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int IntN(int n)
{
    if (n % 10 > 0)
        return n % 10 + IntN(n / 10);
    else
        return 0;
}

int n = Prompt("Введите число N: ");
int result = IntN(n);
System.Console.WriteLine(result);