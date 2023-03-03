// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
            Console.Write($"{matrix[i, j],3} "); // форматирование строки
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

int SumElements(int[,] matrix)
{
    int sum = 0;
    // int size = matrix.GetLength(0);
    // if (size > matrix.GetLength(1)) size = matrix.GetLength(1);

    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

Console.Clear();

int matrixRows = 4; //Promt("Введите количество строк: ");
int matrixColumns = 4; //Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 1; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);
int sumElements = SumElements(array2D);
Console.WriteLine($"Сумма элементов главной диагонали = {sumElements}");