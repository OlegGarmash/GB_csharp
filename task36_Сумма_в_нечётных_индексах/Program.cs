/*
Напишите программу, которая находит сумму элементов с нечетными индексами 
в одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, который принимает массив целых чисел 
и возвращает сумму элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
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
        array[i] = Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum = sum + array[i];
    }
    return sum;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Сумма нечетных элементов: {SumOddElements(arrayOne)}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);