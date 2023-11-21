/*
Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
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

void PrintMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    System.Console.WriteLine("\nДвумерный массив:");
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
            Console.ResetColor();
        }
    }
    System.Console.WriteLine("\nНовый массив:");
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write(matrixTwo[i, j]);
            if (j < matrixTwo.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
            Console.ResetColor();
        }
    }
}

int[,] SortString(int[,] matrixOne)
{
    int[,] matrixTwo = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixTwo[i, j] = matrixOne[i, j];
        }
    }
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int n = 0; n < matrixTwo.GetLength(1) - 1; n++)
            {
                if (matrixTwo[i, j] > matrixTwo[i, n])
                {
                    temp = matrixTwo[i, j];
                    matrixTwo[i, j] = matrixTwo[i, n];
                    matrixTwo[i, n] = temp;
                }
            }
        }
    }
    return matrixTwo;
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintMatrix(matrix, SortString(matrix));