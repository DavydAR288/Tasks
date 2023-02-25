// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// int Prompt(string message, int checkNum) // checkNum: -1 отрицательные; 0 любые; 1 положительные; 2 натуральные;
// {
//     int k = 0;
//     while (k == 0)
//     {
//         Console.Write(message);
//         int cc = Convert.ToInt32(Console.ReadLine());

//         if (checkNum == 0) // любые
//         {
//             return cc;
//         }

//         if (cc >= 0 && checkNum == 1) // положительные
//         {
//             return cc;
//         }

//         if (cc > 0 && checkNum == 2) // натуральные
//         {
//             return cc;
//         }

//         if (cc <= 0 && checkNum == -1) // отрицательные
//         {
//             return cc;
//         }

//         Console.WriteLine("Число не соответствует заданному диапазону. Повторите ввод.");
//     }
//     return 0;
// }

double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double FindMax(double[] arr)
{
    double max = arr[0];
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

Console.Clear();

int quantity = 5; //Prompt("Введите число элементов массива (натуральное): ", 2);
int min = 0;
int max = 99;
double[] array = CreateArray(quantity, min, max);

Console.Write("Массив -> ");
PrintArray(array);

double result = FindMax(array) - FindMin(array);
Console.Write($"Разница между максимальным и минимальным элементами массива -> {result}");






// int minN = -999;
// int maxN = 99;
// double x=0;                     //0-0.999  0.1             1098                        109.8    -999        -899.2  
// Random rnd = new Random();      //0-0.999  0.9             1098                        988.2    -999        -10.8  
// for (int i = 0; i < 5; i++) {x=rnd.NextDouble() * (maxN - minN); Console.WriteLine($"{x} + {minN} = {x+minN}"); };

// Console.WriteLine($"maxN - minN = {maxN - minN}");
// Console.WriteLine($"(maxN - minN) + minN) = {(maxN - minN) + minN}");
// Console.WriteLine($"(maxN - minN) - minN) = {(maxN - minN) - minN}");
