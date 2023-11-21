/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив: 
8 4 2 4
5 9 2 3
1 4 7 2
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
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            if (i == 0)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else if (i == matrixOne.GetLength(0) - 1)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
        }
    }
    Console.ResetColor();
    System.Console.WriteLine("\nНовый массив:");
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            if (i == 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (i == matrixTwo.GetLength(0) - 1)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixTwo[i, j]);
            if (j < matrixTwo.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
        }
    }
    Console.ResetColor();
}

int[,] ChangeRows(int[,] matrixOne)
{
    int[,] matrixTwo = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    int x = matrixOne.GetLength(0) - 1;
    for (int i = 0; i < matrixOne.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            if (i == 0)
            {
                matrixTwo[0, j] = matrixOne[x, j];
                matrixTwo[x, j] = matrixOne[0, j];
            }
            else
            {
                matrixTwo[i, j] = matrixOne[i, j];
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
PrintMatrix(matrix, ChangeRows(matrix));