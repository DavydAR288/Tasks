﻿// Лекция 4 - многомерные массивы

Console.Clear();

string[,] table = new string[2, 5];

//String.Empty инициализация строк
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
table[1, 2] = "word";

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write ($" -{table[i,j]}- ");
    }
    Console.WriteLine();
}


// Матрица

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - возвращает количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - возвращает количество столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    Random rnd = new Random(); // инициализация рандома
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - возвращает количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - возвращает количество столбцов
        {
            matr[i, j] = rnd.Next(1, 10); // [1, 10)
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


// Закрашивание

int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,0,0,0,0,0,1,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,1,0,0,0,0,0,0},
    {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,1,0,0,0,0,0,0,0},
    {0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,1,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,1,0,1,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,1,1,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++) // 0 - возвращает количество строк
    {
        for (int j = 0; j < image.GetLength(1); j++) // 1 - возвращает количество столбцов
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col); // проверка закрашивания вверх
        FillImage(row, col - 1); // проверка закрашивания влево
        FillImage(row + 1, col); // проверка закрашивания вниз
        FillImage(row, col + 1); // проверка закрашивания вправо
    }

}

PrintImage(pic);
FillImage(15, 15);
PrintImage(pic);




// Рекурсия факториал

double Factorial(int n)
{
    if (n == 1) return 1; // по определению факториала, 1!=1, 0!=0
    else return n* Factorial(n-1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}={Factorial(i)}");
}




// Числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n==1 || n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"{i}={Fibonacci(i)}");
}