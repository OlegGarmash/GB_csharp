/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4. 
0,5 7 -2 -0,2 
1 -3,3 8 -9,9 
8 7,8 -7,1 9
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
            matrix[i, j] = Math.Round(new Random().NextDouble() * (maxValue + 0.01 - minValue) + minValue, 2);
        }
    }
    return matrix;
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