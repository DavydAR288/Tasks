// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero); // случайное вещественное число
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        Console.Write($"{matrix[i,j], 6} "); // форматирование строки
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


Console.Clear();

int matrixRows = Promt("Введите количество строк: ");
int matrixColumns = Promt("Введите количество столбцов: ");
int maxRnd = -10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 10; //Promt("Введите нижний предел случйного числа: ");

double[,] array2D = CreateMatrixRndDouble(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);