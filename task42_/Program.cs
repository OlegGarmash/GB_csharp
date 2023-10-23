/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] IntToBinary(int number)
{
    int size = 0;
    int temp = number;
    while (number != 0)
    {
        number = number / 2;
        size++;
    }
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[size - 1 - i] = temp % 2;
        temp = temp / 2;
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Двоичное число: ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
    }
    Console.ResetColor();
}

int number = Prompt("Введите десятичное число: ");
PrintArray(IntToBinary(number));