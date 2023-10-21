/*
Напишите программу, которая подсчитывает количество четных элементов
в массиве целых положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, который принимает 
массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
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

int CountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
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
    System.Console.Write($"Количество четных элементов: {CountEvenElements(arrayOne)}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);
