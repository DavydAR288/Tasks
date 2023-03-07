// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int[] FindIndex(int[,] matrix)
{
    int row=0;
    int column=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= matrix[row, column])
            {
                row =i;
                column =j;
            }
        }
    }
    return new int[] {row,column};
}

int[,] CorrectMatrix(int[,] matrix, int[] index)
{
    int[,] matrixNew = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int m=0, n=0;

    for (int i = 0; i < matrixNew.GetLength(1); i++)
    {
        if (i==index[0]) m++;
        for (int j = 0; j < matrixNew.GetLength(0); j++)
        {
            if (j==index[1]) n++;
            matrixNew[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n=0;
    }
    return matrixNew;
}

Console.Clear();

int matrixRows = 6; //Promt("Введите количество строк: ");
int matrixColumns = 6; //Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = -10; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);
Console.WriteLine();

int[] indexArray = FindIndex(array2D);

Console.WriteLine($"Строка - {indexArray[0]+1}");
Console.WriteLine($"Столбец - {indexArray[1]+1}");

int[,] array2Dnew = CorrectMatrix(array2D, indexArray);
PrintArray(array2Dnew);
