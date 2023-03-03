// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] AverageArray(int[,] matrix)
{
    int size = matrix.GetLength(1);
    double[] resArr = new double[size];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average += matrix[j, i];
        }
        resArr[i] = average / matrix.GetLength(1);
    }
    return resArr;
}

void PrintResultArray(double[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=Math.Round(array[i], 2);
        Console.Write($"{array[i],6} ");
    }
}


Console.Clear();

int matrixRows = Promt("Введите количество строк: ");
int matrixColumns = Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 1; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);
double[] averageArray = AverageArray(array2D);
Console.Write("Среднее арифметическое:");
PrintResultArray(averageArray);
