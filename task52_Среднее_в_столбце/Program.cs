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

int[,] CreateIncreasingMatrix(int rows, int columns, int coefficient)
{
    int[,] matrix = new int[rows, columns];
    int temp = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = temp;
            temp = temp + coefficient;
        }
    }
    return matrix;
}

double[] FindAverageInColumns(int[,] matrixOne)
{
    double[] average = new double[matrixOne.GetLength(1)];
    for (int j = 0; j < matrixOne.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {
            temp = matrixOne[i, j] + temp;
        }
        average[j] = Math.Round(temp / matrixOne.GetLength(0), 2);
    }
    return average;
}

void PrintMatrix(int[,] matrixOne, double[] arrayOne)
{
    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    System.Console.WriteLine("\nДвумерный массив:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else
                System.Console.WriteLine();
        }
    }
    Console.ResetColor();
    System.Console.WriteLine("\nСреднее значение в колонках:");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write("{0:0.00}", arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write("\t");
    }
    Console.ResetColor();
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int k = Prompt("Введите коэффициент матрицы: ");
int[,] matrix = CreateIncreasingMatrix(rows, columns, k);
PrintMatrix(matrix, FindAverageInColumns(matrix));

