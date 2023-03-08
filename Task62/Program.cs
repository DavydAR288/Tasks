// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int startElement = 1, // стартовый элемент
        count = 0, // счетчик прохода 4-х напрвлений "колец"
        quantitySteps = 0; // счетчик проверки количества элементов массива для запуска циклов направлений
    for (quantitySteps = 0; quantitySteps <= rows * columns; quantitySteps++)
    {
        for (int j = 0 + count; j < columns - 1 - count; j++) // заполнение вправо
        {
            matrix[0 + count, j] = startElement++;
            quantitySteps++;
        }
        for (int i = 0; i < rows - 1 - count * 2; i++) // заполнение вниз 
        {
            matrix[i + count, columns - 1 - count] = startElement++;
            quantitySteps++;
        }
        for (int j = columns - 1 - count; j > 0 + count; j--) // заполнение влево
        {
            matrix[rows - 1 - count, j] = startElement++;
            quantitySteps++;
        }
        for (int i = rows - 1 - count; i > 0 + count; i--) // заполнение вверх
        {
            matrix[i, 0 + count] = startElement++;
            quantitySteps++;
        }
        count++;
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

int[,] matrix2d = CreateMatrixRndInt(matrixRows, matrixColumns);
PrintArray(matrix2d);
Console.WriteLine();

