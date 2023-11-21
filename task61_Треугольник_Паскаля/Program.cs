/*
Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.
*/


int Prompt(string massage)
{
    System.Console.Write(massage);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    int result = Convert.ToInt32(Console.ReadLine());
    Console.ResetColor();
    return result;
}

int[,] GenerateMatrix(int n)
{
    int rows = n;
    int columns = n * 2 + 1;
    int[,] matrix = new int[rows, columns];
    matrix[0, n] = 1;
    for (int i = 0; i < rows; i++)
    {
        matrix[i, 0] = 0;
        matrix[i, columns - 1] = 0;
        for (int j = 1; j < columns - 1; j++)
        {
            if (i == 0)
            {
                if (j != n)
                    matrix[i, j] = 0;
            }
            else
                matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
        }
    }
    return matrix;
}

void PrintBaseMatrix(int[,] matrixOne)
{
    System.Console.WriteLine("\nТреугольник Паскаля:");
    Console.ForegroundColor = ConsoleColor.Cyan;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 1; j < matrixOne.GetLength(1) - 1; j++)
        {
            if (matrixOne[i, j] == 0)
                System.Console.Write("");
            else
                System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 2)
                System.Console.Write("\t");
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}

int n = Prompt("Введите число N: ");
int[,] matrix = GenerateMatrix(n);
PrintBaseMatrix(matrix);