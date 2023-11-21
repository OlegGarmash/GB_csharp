/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,] GenerateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int tempSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        tempSum = tempSum + matrix[0, j];
    }
    int[] sumMin = { 0, tempSum };
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int min = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min = min + matrix[i, j];
        }
        if (sumMin[1] > min)
        {
            sumMin[0] = i;
            sumMin[1] = min;
        }
    }
    return sumMin;
}

void PrintBaseMatrix(int[,] matrixOne)
{
    System.Console.WriteLine("\nВводные данные:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            if (i == MinimumSumRow(matrixOne)[0])
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            Console.ResetColor();
        }
        System.Console.WriteLine();
    }
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintBaseMatrix(matrix);

int[] minSumRow = MinimumSumRow(matrix);

Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

int rowToSum = 1;
int sum = SumOfRow(matrix, rowToSum);
Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");