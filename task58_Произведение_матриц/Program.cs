/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixResult = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int m = 0; m < matrixResult.GetLength(0); m++)
    {
        for (int n = 0; n < matrixResult.GetLength(1); n++)
        {
            int tempSum = 0;
            for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                tempSum = tempSum + matrixA[m, j] * matrixB[j, n];
            }
            matrixResult[m, n] = tempSum;
        }
    }
    return matrixResult;
}

void PrintBaseMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    System.Console.WriteLine("\nВводные данные:");
    System.Console.WriteLine("Матрица A");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
    System.Console.WriteLine("\nМатрица B");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            System.Console.Write(matrixTwo[i, j]);
            if (j < matrixTwo.GetLength(1) - 1)
                System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        System.Console.WriteLine("\nIt is impossible to multiply.");
    else PrintResultMatrix(MatrixMultiplication(matrixA, matrixB));
}

void PrintResultMatrix(int[,] matrixResult)
{
    System.Console.WriteLine("\nИскомый результат:");
    Console.ForegroundColor = ConsoleColor.Cyan;
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            System.Console.Write(matrixResult[i, j]);
            if (j < matrixResult.GetLength(1) - 1)
                System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

int rows = Prompt("Количество строк матрицы A: ");
int columns = Prompt("Количество столбцов матрицы A: ");
int min = Prompt("Минимальное значение матрицы A: ");
int max = Prompt("Максимальное значене матрицы A: ");
System.Console.WriteLine();
int rowsB = Prompt("Количество строк матрицы B: ");
int columnsB = Prompt("Количество столбцов матрицы B: ");
int minB = Prompt("Минимальное значение матрицы B: ");
int maxB = Prompt("Максимальное значене матрицы B: ");
int[,] matrixOne = GenerateMatrix(rows, columns, min, max);
int[,] matrixTwo = GenerateMatrix(rowsB, columnsB, minB, maxB);
PrintBaseMatrix(matrixOne, matrixTwo);
MultiplyIfPossible(matrixOne, matrixTwo);