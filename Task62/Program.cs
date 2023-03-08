// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

// int Promt(string message)
// {
//     Console.Write(message);
//     string value = (Console.ReadLine());
//     int result = Convert.ToInt32(value);
//     return result;
// }


Console.Clear();

int matrixRows = 4; //Promt("Введите количество строк: ");
int matrixColumns = 4; //Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = -10; //Promt("Введите нижний предел случйного числа: ");

int[,] matrix2d = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(matrix2d);
Console.WriteLine();

