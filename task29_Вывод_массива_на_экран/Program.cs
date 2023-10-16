/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

System.Console.WriteLine("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());



int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите эллемент массива №{i + 1}:");
        int temp = Convert.ToInt32(Console.ReadLine());
        array[i] = temp;
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            System.Console.Write($"{arr[i]}, ");
        else if (i == arr.Length - 1)
            System.Console.Write($"{arr[i]}");
    }
    System.Console.Write($" -> [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            System.Console.Write($"{arr[i]}, ");
        else if (i == arr.Length - 1)
            System.Console.Write($"{arr[i]}]");
    }
}

int[] userArray = GetArray(arraySize);
PrintArray(userArray);