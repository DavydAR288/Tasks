// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Array.Sort() - сортировка одномерного массива

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

void PrintArray1d(int[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
            Console.Write($"{matrix[i],6} "); // форматирование строки
    }
}

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    return result;
}

int[] DictionaryMatrix(int[,] matrix)
{
    int k=0;
    int[,] matrixNew = new int[2, 10];
    int[] tempSortArray= new int[matrix.GetLength(0)*matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSortArray[k] = matrix[i, j];
            k+=1;
        }
    }

    return tempSortArray;
}

// добавить метод вывода по сорту

Console.Clear();

int matrixRows = 3; //Promt("Введите количество строк: ");
int matrixColumns = 3; //Promt("Введите количество столбцов: ");
int maxRnd = 10; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 1; //Promt("Введите нижний предел случйного числа: ");

int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns, minRnd, maxRnd);
PrintArray(array2D);
Console.WriteLine();
int[] dictionary = DictionaryMatrix(array2D);
Array.Sort(dictionary);
PrintArray1d(dictionary);
