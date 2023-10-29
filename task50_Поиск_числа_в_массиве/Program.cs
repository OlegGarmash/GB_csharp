/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
17 -> такого числа в массиве нет
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

/*int[] FindNumberByPosition(int[,] matrixOne, int rowPosition, int columnPosition)
{
    int[] findNumber = new int[2];
    findNumber[1] = 0;
    if (rowPosition > matrixOne.GetLength(0) - 1 || columnPosition > matrixOne.GetLength(1) - 1)
        findNumber[0] = 0;
    else
        findNumber[0] = matrixOne[rowPosition, columnPosition];
    return findNumber;
}*/

/*void PrintCheckIfError(int[] find, int x, int y)
{
    if (find[0] > 0)
        System.Console.WriteLine($"Число на позиции [{x}, {y}] равно {find[0]}.");
    else
        System.Console.WriteLine($"Строка или столбец не соответствует матрице.");
}*/

void PrintMatrix(int[,] matrixOne, int x, int y)
{
    System.Console.WriteLine("\nДвумерный массив:");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            if (i == x && j == y)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            else
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.Write(matrixOne[i, j]);
            if (j < matrixOne.GetLength(1) - 1)
                System.Console.Write("\t");
            else
                System.Console.WriteLine();
        }
    }
    Console.ResetColor();
    if (x < matrixOne.GetLength(0) && y < matrixOne.GetLength(1))
        System.Console.WriteLine($"\nЧисло на позиции [{x}, {y}] равно {matrixOne[x, y]}.");
    else
        System.Console.WriteLine($"\nСтрока или столбец не соответствует матрице.");
}

int rows = Prompt("Количество строк: ");
int columns = Prompt("Количество столбцов: ");
int k = Prompt("Введите коэффициент матрицы: ");
int posX = Prompt("Введи номер строки: ");
int posY = Prompt("Введи номер столбца: ");
int[,] matrix = CreateIncreasingMatrix(rows, columns, k);
PrintMatrix(matrix, posX, posY);
//PrintCheckIfError(FindNumberByPosition(matrix, posX, posY), posX, posY);