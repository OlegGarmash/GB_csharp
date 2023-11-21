/*
Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int IntN(int a, int b)
{
    if (b == 1) return a;
    else return a * IntN(a, b - 1);
}

int a = Prompt("Введите число A: ");
int b = Prompt("Введите степень B: ");
int result = IntN(a, b);

System.Console.WriteLine(result);