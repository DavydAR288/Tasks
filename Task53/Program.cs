// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

int[,] ReplaceElementMatrix(int[,] matrix)
{
    int temp=matrix[0,0];
    int lastString=matrix.GetLength(1)-1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        temp=matrix[0,i];
        matrix[0,i]=matrix[lastString,i];
        matrix[lastString,i]=temp;
    }
    return matrix;
}


Console.Clear();

int matrixRows = 6; //Promt("Введите количество строк: ");
int matrixColumns = 6; //Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 1; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);
Console.WriteLine();
int[,] array2Dnew=ReplaceElementMatrix (array2D);
PrintArray(array2Dnew);
