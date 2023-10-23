/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3 
[6 7 3 6] -> 12 10
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

int[] Multiplication(int[] array)
{
    int size = array.Length - array.Length / 2;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
        result[size - 1] = array[size - 1];
    return result;
}

void PrintArray(int[] arrayOne, int[] arrayTwo)
{
    System.Console.Write("\n[");
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
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, Multiplication(array));