/*
Напишите программу, которая будет создавать копию заданного
одномерного массива с помощью поэлементного копирования.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    array.CopyTo(copy, 0);
    return copy;
}

void PrintArray(int[] arrayOne, int[] arrayTwo)
{
    System.Console.WriteLine("\nМассив:");
    
    System.Console.Write("[");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    Console.ResetColor();
    System.Console.Write("] -> [");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    for (int i = 0; i < arrayTwo.Length; i++)
    {
        System.Console.Write(arrayTwo[i]);
        if (i < arrayTwo.Length - 1)
            System.Console.Write(", ");
    }
    Console.ResetColor();
    System.Console.WriteLine("]");
    
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, CopyArray(array));