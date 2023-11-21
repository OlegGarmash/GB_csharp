/*
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int FindMax(int[,] array)
{
    int max = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (max < array[i, j])
                max = array[i, j];
        }
    }
    return max;
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

void PrintBaseMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    System.Console.WriteLine("\nВводные данные:");
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
    System.Console.WriteLine("\nМатрица подсчёта:");
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
void PrintResultMatrix(int[,] matrixOne)
{
    System.Console.WriteLine("\nИскомый результат:");
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {

        if (matrixOne[i, 1] == 1 || matrixOne[i, 1] > 4)
        {

            System.Console.Write("Число ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write(matrixOne[i, 0]);
            Console.ResetColor();
            System.Console.Write(" встречается ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write(matrixOne[i, 1]);
            Console.ResetColor();
            System.Console.WriteLine(" раз.");
        }
        else
            {System.Console.Write("Число ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.Write(matrixOne[i, 0]);
        Console.ResetColor();
        System.Console.Write(" встречается ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.Write(matrixOne[i, 1]);
        Console.ResetColor();
        System.Console.WriteLine(" раза.");}
    }
}

int[,] CountMatrix(int[,] matrixTwo)
{int countLength = 0;

    for (int k = FindMin(matrixTwo); k <= FindMax(matrixTwo); k++)
    {
        int count = 0;
        for (int i = 0; i < matrixTwo.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                if (k == matrixTwo[i, j])
                    count++;
            }
        }
        if (count > 0)
        {
            countLength++;
        }
    }
    int[,] countMatrix = new int[countLength,2];
    int countNum = 0;
    for (int k = FindMin(matrixTwo); k <= FindMax(matrixTwo); k++)
    {
        int count = 0;
        for (int i = 0; i < matrixTwo.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                if (k == matrixTwo[i, j])
                    count++;
            }
        }
        if (count > 0)
        {
            countMatrix[countNum, 0] = k;
            countMatrix[countNum, 1] = count;
            countNum++;
        }
    }
    return countMatrix;
}

/*void CountNumbers(int[,] matrixTwo)
{
    for (int k = FindMin(matrixTwo); k <= FindMax(matrixTwo); k++)
    {
        int count = 0;
        for (int i = 0; i < matrixTwo.GetLength(0); i++)
        {
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                if (k == matrixTwo[i, j])
                    count++;
            }
        }
        if (count > 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (count == 1 || count > 4)
                System.Console.WriteLine($"Число {k} встречается {count} раз.");
            else
                System.Console.WriteLine($"Число {k} встречается {count} раза.");
            Console.ResetColor();
        }
    }
}*/

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int min = Prompt("Минимальное значение: ");
int max = Prompt("Максимальное значене: ");
int[,]
matrix = GenerateMatrix(rows, columns, min, max);
PrintBaseMatrix(matrix,CountMatrix(matrix));
PrintResultMatrix(CountMatrix(matrix));