/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
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

int[] Reverse(int[] array)
{
    int[] revArray = new int[array.Length];
    for (int i = 0; i < revArray.Length; i++)
    {
        revArray[i] = array[array.Length - 1 - i];
    }
    return revArray;
}

void PrintArray(int[] arrayOne, int[] arrayTwo)
{
    System.Console.WriteLine("\nМассив:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> [");
    for (int i = 0; i < arrayTwo.Length; i++)
    {
        System.Console.Write(arrayTwo[i]);
        if (i < arrayTwo.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
    Console.ResetColor();
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, Reverse(array));