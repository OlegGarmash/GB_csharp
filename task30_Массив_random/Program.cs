/*
Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
*/

System.Console.WriteLine("Введите размер массива:");
int userA = Convert.ToInt32(Console.ReadLine());

int[] GetRandArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}

int[] userArray = GetRandArray(userA);
PrintArray(userArray);