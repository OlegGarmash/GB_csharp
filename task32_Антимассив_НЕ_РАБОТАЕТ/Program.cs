/*
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] AntiArray(int[] antiA)
{
    for (int i = 0; i < antiA.Length; i++)
    {
        antiA[i] = -1 * antiA[i];
    }
    return antiA;
}

void PrintArray(int[] arrayOne, int[] arrayTwo)
{
    System.Console.WriteLine();
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
        // array[i] = -1 * array[i];
        System.Console.Write(arrayTwo[i]);
        if (i < arrayTwo.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, array); // выводим базу на экран (дважды)
// int[] antiArr = AntiArray(array);
PrintArray(array, AntiArray(array)); // видим что алгоримт работает некорректно