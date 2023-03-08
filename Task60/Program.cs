// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int sizeDictionary = rows * columns * depth;
    int[] dictionary = new int[sizeDictionary];
    int indexDictionary = 0;
    int randomElement=0;
    Random rnd = new Random();
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                do
                {
                    randomElement = rnd.Next(min, max + 1);
                } while (dictionary.Contains(randomElement));
                matrix[i, j, k] = randomElement;
                dictionary[indexDictionary] = randomElement;
                indexDictionary++;
            }
        }
    }
    Array.Sort(dictionary);                                 // Используется для отображения словаря, оценки его корректности
    Console.Write("Словарь используемых элементов: ");      // 
    for (int n = 0; n < sizeDictionary; n++)                // НЕ ЯВЛЯЕТСЯ ОБЯЗАТЕЛЬНОЙ ЧАСТЬЮ ВЫПОЛНЕНИЯ ПРОГРАММЫ И ЕЁ ЗАДАЧИ ДЛЯ ДЗ
    {                                                       // 
        Console.Write($"{dictionary[n]} ");                 // 
    }                                                       // 
    Console.WriteLine();                                    // 
    return matrix;
}

void PrintArray3d(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        Console.WriteLine($"Слой глубины массива: {k}");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j, k],6} ({i}, {j}, {k})"); // форматирование строки
            }
            Console.WriteLine();
        }
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

int matrixRows = 2; //Promt("Введите количество строк массива: ");
int matrixColumns = 2; //Promt("Введите количество столбцов массива: ");
int matrixDepth = 2; //Promt("Введите глубину массива: ");
int maxRnd = 99; //Promt("Введите верхний предел случйного числа: ");
int minRnd = 10; //Promt("Введите нижний предел случйного числа: ");

int sizeMatrix=matrixRows*matrixColumns*matrixDepth;
if (sizeMatrix<maxRnd-minRnd+1)
{
    int[,,] matrix3d = CreateMatrixRndInt(matrixRows, matrixColumns, matrixDepth, minRnd, maxRnd);
    PrintArray3d(matrix3d);
    Console.WriteLine();
}
else Console.WriteLine($"Заданный размер матрицы <элементов: {sizeMatrix}> не позволяет заполнить её неповторяющимися значениями,"+
                        $" т.к. превышает числовой ряд от {minRnd} до {maxRnd}");
