/*
 Задайте двумерный массив размера m на n, каждый элемент в массиве 
 находится по формуле: Aₘₙ= m+n. Выведите полученный массив на экран. 
 m = 3, n = 4. 
 0 1 2 3 
 1 2 3 4 
 2 3 4 5
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,] GenerateMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixOne)
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
int[,] matrix = GenerateMatrix(rows, columns);
PrintMatrix(matrix);