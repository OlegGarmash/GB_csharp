/*
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

int Prompt(string message)
{
    System.Console.Write(message);
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


bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

void PrintArray(int[] arrayOne, bool a)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> ");
    if (a == true) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int num = Prompt("Проверка числа в массиве: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, findNum(array, num));