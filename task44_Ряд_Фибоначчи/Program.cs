/*
Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[] Fibonachi(int number)
{
    int[] array = new int[number + 1];
    if (number == 1)
        array = new int[2] { 0, 1 };
    if (number == 0)
        array = new int[1] { 1 };
    if (number > 1)
    {
        array[0] = 0;
        array[1] = 1;
        for (int i = 2; i < number + 1; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
    }
    return array;
}

void PrintArray(int[] arrayOne, int n)
{
    System.Console.Write("\nЧисло N = " + n + ": ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    Console.ResetColor();
}

int number = Prompt("Введите число для ряда Фибоначчи: ");
PrintArray(Fibonachi(number), number);