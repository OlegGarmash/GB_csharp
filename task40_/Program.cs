/*
Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
*/

int[] GenerateArray()
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        System.Console.Write($"Введите сторону {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool Triangl(int[] array)
{
    return array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[1] + array[2] > array[0];
}

void Print(int[] arrayOne)
{
    System.Console.WriteLine("Это треугольник - " + Triangl(arrayOne));
}

int[] array = GenerateArray();
Print(array);