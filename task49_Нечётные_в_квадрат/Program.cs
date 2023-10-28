/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так: 
1 4 7 2 
5 9 2 3 
8 4 2 4

Новый массив будет выглядеть вот так: 
1 4 7 2 
5 81 2 9 
8 4 2 4
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

double[,] GenerateMatrix(int rows, int columns, int minValue, int maxValue)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

double[,] CloneMatrix(double[,] matrixOne)
{
    double[,] matrixClone = new double[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    // double a = 0;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            //a = matrixOne[i, j];
            matrixClone[i, j] = matrixOne[i, j];
        }
    }
    return matrixClone;
}

double[,] NewMatrix(double[,] matrixOne)
{
    double[,] matrixTwo = CloneMatrix(matrixOne);
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                matrixTwo[i, j] = Math.Pow(matrixTwo[i, j], 2);
        }
    }
    return matrixTwo;
}

void PrintMatrix(double[,] matrixOne, double[,] matrixTwo)
{
    System.Console.WriteLine("\nДвумерный массив:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
        }
    }
    Console.ResetColor();
    System.Console.WriteLine("\nНовый массив:");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            System.Console.Write(matrixTwo[i, j]);
            if (j < matrixTwo.GetLength(1) - 1)
                System.Console.Write("\t");
            else System.Console.WriteLine();
        }
    }
    Console.ResetColor();
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
double[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintMatrix(matrix, NewMatrix(matrix));