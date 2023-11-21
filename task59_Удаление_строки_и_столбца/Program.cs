/*
Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива. 
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
5 2 6 7 
Наименьший элемент - 1, на выходе получим следующий массив: 
9 4 2 
2 2 6 
3 4 7
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

int FindMin(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
                min = array[i, j];
        }
    }
    return min;
}

int[] FindIndexMin(int[,] array)
{
    int[] indexMin = { 0, 0 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (FindMin(array) == array[i, j])
            {
                indexMin[0] = i;
                indexMin[1] = j;
                return indexMin;
            }
        }
    }
    return indexMin;
}

int[,] ResultMatrix(int[,] matrixOne)
{
    int rowLength = matrixOne.GetLength(0);
    int colLength = matrixOne.GetLength(1);
    if (FindIndexMin(matrixOne)[0] == rowLength - 1) rowLength--;
    if (FindIndexMin(matrixOne)[1] == colLength - 1) colLength--;

    int[,] matrixResult = new int[matrixOne.GetLength(0) - 1, matrixOne.GetLength(1) - 1];
    int m = 0;
    for (int i = 0; i < rowLength; i++)
    {
        int n = 0;
        if (i == FindIndexMin(matrixOne)[0]) i++;
        for (int j = 0; j < colLength; j++)
        {
            if (j == FindIndexMin(matrixOne)[1]) j++;
            matrixResult[m, n] = matrixOne[i, j];
            n++;
        }
        m++;
    }
    return matrixResult;
}

void PrintBaseMatrix(int[,] matrixOne)
{
    System.Console.WriteLine("\nВводные данные:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            if (i == FindIndexMin(matrixOne)[0] || j == FindIndexMin(matrixOne)[1])
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



int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,] matrix = GenerateMatrix(rows, columns, min, max);
PrintBaseMatrix(matrix);
PrintResultMatrix(ResultMatrix(matrix));