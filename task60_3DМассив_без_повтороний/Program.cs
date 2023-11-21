/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,,] GenerateMatrix(int rows, int columns, int z, int minValue, int maxValue)
{
    int[] array = new int[rows * columns * z];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    i--;
                }
            }
        }
    }
    int[,,] matrix = new int[rows, columns, z];
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = array[count];
                count++;
            }
        }
    }
    return matrix;
}

void PrintResultMatrix(int[,,] matrixResult)
{
    System.Console.WriteLine("\nИскомый результат:");

    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            for (int k = 0; k < matrixResult.GetLength(2); k++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.Write($"[{i}, {j}, {k}] -> ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine(matrixResult[i, j, k]);
            }
        }
        Console.ResetColor();
    }
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int z = Prompt("Глубина массива: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
if (rows * columns * z < max - min + 1)
{
    int[,,] matrix = GenerateMatrix(rows, columns, z, min, max);
    PrintResultMatrix(matrix);
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.WriteLine("\nНЕВОЗМОЖНО СОЗДАТЬ МАССИВ С НЕПОВТОРЯЮЩИМИСЯ ЗНАЧЕНИЯМИ!");
    Console.ResetColor();
}