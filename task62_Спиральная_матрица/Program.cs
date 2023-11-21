/*
Заполните спирально массив 4 на 4.
1  2  3  4
12 13 14 5
11 16 15 6
10 9  8  7
*/

int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,] Spiral(int n)
{
    int[,] spiralMatrix = new int[n, n];
    int k = 1;
    int i = 0;
    int j = 0;

    while (k <= n * n)
    {
        spiralMatrix[i, j] = k;
        k++;
        if (i <= j + 1 && i + j < n - 1)
        {
            j++;
        }
        else if (i < j && i + j >= n - 1)
        {
            i++;
        }
        else if (i >= j && i + j > n - 1)
        {
            j--;
        }
        else
            i--;

    }
    return spiralMatrix;
}



void PrintBaseMatrix(int[,] matrixOne)
{
    System.Console.WriteLine("\nСпиральная матрица:");
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
}

int n = Prompt("Введите размер квадратной матрицы: ");
PrintBaseMatrix(Spiral(n));