/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}


int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите эллемент массива № {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

void PrintArray(int[] arrayOne)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    Console.ResetColor();
    System.Console.Write(" -> ");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(CountNum(arrayOne));
    Console.ResetColor();
}

int size = Prompt("Введите количество чисел: ");

PrintArray(GetArray(size));