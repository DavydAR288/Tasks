// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

// Произведение матрицы А порядка PxN и матрицы В порядка NxQ - это такая матрица С порядка PxQ
// каждый элемент которой равен сумме произведений элементов i-ой строки матрицы А на соответствующие элементы j-ого столбца матрицы В

int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB)
{
    int rowsC = matrixA.GetLength(0),
        columnsC = matrixB.GetLength(1);
    int[,] matrixC = new int[rowsC, columnsC];

    for (int i = 0; i < rowsC; i++)
    {
        for (int j = 0; j < columnsC; j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.Clear();

int matrixRowsOne = 3; //Promt("Введите количество строк: ");
int matrixColumnsOne = 2; //Promt("Введите количество столбцов: ");
int maxRnd = 5; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 1; //Promt("Введите нижний предел случйного числа: ");

int[,] matrixOne = CreateMatrixRndInt(matrixRowsOne, matrixColumnsOne, minRnd, maxRnd);
Console.WriteLine("Матрица А:");
PrintArray(matrixOne);
Console.WriteLine();

int matrixRowsTwo = 2; //Promt("Введите количество строк: ");
int matrixColumnsTwo = 3; //Promt("Введите количество столбцов: ");

int[,] matrixTwo = CreateMatrixRndInt(matrixRowsTwo, matrixColumnsTwo, minRnd, maxRnd);
Console.WriteLine("Матрица B:");
PrintArray(matrixTwo);
Console.WriteLine();

if (matrixOne.GetLength(1) == matrixTwo.GetLength(0))
{
    Console.WriteLine("Произведение матрицы А порядка PxN и матрицы В порядка NxQ - это такая матрица С порядка PxQ,");
    Console.WriteLine("каждый элемент которой равен сумме произведений элементов i-ой строки матрицы А на соответствующие элементы j-ого столбца матрицы В;");
    Console.WriteLine();
    Console.WriteLine("Матрица C:");
    int[,] matrixResult = MultiplicationMatrix(matrixOne, matrixTwo);
    PrintArray(matrixResult);
    Console.WriteLine();
}
else Console.WriteLine("Операция не произведена! Операция умножения двух матриц А и В определяется только для случая, когда ЧИСЛО СТОЛБЦОВ МАТРИЦЫ А РАВНО ЧИСЛУ СТРОК МАТРИЦЫ В");

