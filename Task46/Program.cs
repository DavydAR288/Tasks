// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

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
        Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    // Console.WriteLine();
    return result;
}

Console.Clear();

int matrixRows = Promt("Введите количество строк: ");
int matrixColumns = Promt("Введите количество столбцов: ");
int maxRnd = Promt("Введите верхний предел случйного числа: ");
int minRnd = Promt("Введите нижний предел случйного числа: ");

int[,] matrix = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(matrix);