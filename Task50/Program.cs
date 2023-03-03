// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6} "); // форматирование строки
        }
        Console.WriteLine();
    }
}

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int FindElementPosition(int[,] matrix, int[] position)
{
    int row = position[0];
    int column = position[1];
    return matrix[row, column];
}

Console.Clear();

int matrixRows = Promt("Введите количество строк: ");
int matrixColumns = Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = -10; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);

int findElementRow = Promt("Введите позицию по строке: ");
int findElementColumn = Promt("Введите позицию по столбцу: ");
int[] positionArray = { findElementRow, findElementColumn };

if (findElementRow < array2D.GetLength(0) && findElementColumn < array2D.GetLength(1))
{
    int resultFindElement = FindElementPosition(array2D, positionArray);
    Console.Write($"Элемент матрицы на искомой позиции = {resultFindElement}");
}
else Console.Write($"Такого элемента в массиве нет (введены позиции элемента за пределами размера матрицы)");