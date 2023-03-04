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

bool FindElementPosition(int[,] matrix, int[] position)
{
    int row = position[0];
    int column = position[1];
    if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1) || row < 0 || column < 0) return false;
    else return true;
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
int[] positionArray = { findElementRow, findElementColumn};

bool resultFindElement = FindElementPosition(array2D, positionArray);
if (resultFindElement)
{
    int result = array2D[positionArray[0], positionArray[1]];
    Console.Write($"Элемент матрицы на искомой позиции = {result}");
}
else Console.Write($"Такого элемента в массиве нет (введены позиции элемента за пределами размера матрицы)");

// dotnet --list-sdks
// 6.0.405 [C:\Program Files\dotnet\sdk]
// 7.0.200 [C:\Program Files\dotnet\sdk]


// dotnet sdk check
// Пакеты SDK для .NET:
// Версия       Состояние
// ------------------------------------------
// 6.0.405      Доступно исправление 6.0.406.
// 7.0.200      Доступно исправление 7.0.201.

// Ознакомьтесь с новейшими компонентами пакета SDK для .NET в среде .NET 8.0.100-preview.1.23115.2.

// Среды выполнения .NET:
// Имя                               Версия      Состояние
// --------------------------------------------------------------------------
// Microsoft.AspNetCore.App          6.0.13      Доступно исправление 6.0.14.
// Microsoft.NETCore.App             6.0.13      Доступно исправление 6.0.14.
// Microsoft.WindowsDesktop.App      6.0.13      Доступно исправление 6.0.14.
// Microsoft.AspNetCore.App          6.0.14      Актуальное состояние.
// Microsoft.NETCore.App             6.0.14      Актуальное состояние.
// Microsoft.WindowsDesktop.App      6.0.14      Актуальное состояние.
// Microsoft.AspNetCore.App          7.0.3       Актуальное состояние.
// Microsoft.NETCore.App             7.0.3       Актуальное состояние.
// Microsoft.WindowsDesktop.App      7.0.3       Актуальное состояние.