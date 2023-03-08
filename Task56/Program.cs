// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int[] FindRowSum(int[,] matrix)
{
    int sum = 0;
    int[] sumMatrix = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumMatrix[i] = sum;
        sum = 0;
    }
    return sumMatrix;
}

int[] CompareSum(int[] matrix)
{
    int minIndex = 0, minSum = matrix[minIndex];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix[i] < minSum)
        {
            minSum = matrix[i];
            minIndex = i;
        }
    }
    return new int[] { minIndex, minSum };
}



Console.Clear();

int matrixRows = 3; //Promt("Введите количество строк: ");
int matrixColumns = 6; //Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = -10; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);
Console.WriteLine();
int[] arraySum = FindRowSum(array2D);
// Console.WriteLine(arraySum[0]);Console.WriteLine(arraySum[1]);Console.WriteLine(arraySum[2]); // вывод суммы строк для проверки корректности алгоритма
int[] result = CompareSum(arraySum);
Console.WriteLine($"Строка с индексом {result[0]}, имеет минимальную сумму {result[1]}");
