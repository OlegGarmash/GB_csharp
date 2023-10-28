/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

double[] ColumnsAverage(int[,] matrixOne)
{
    double[] average = new double[matrixOne.GetLength(0)];
    for (int i = 0; i < matrixOne.GetLength(1); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(0); j++)
        {
            average[j] = matrixOne[j] + average[j];
        }
    }
    return average;
}

void PrintMatrix(double[,] matrixOne)
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
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
double[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintMatrix(matrix);