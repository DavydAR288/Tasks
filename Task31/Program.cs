// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int Prompt(string message, int checkNum) // checkNum: -1 отрицательные; 0 любые; 1 положительные; 2 натуральные;
{
    int k = 0;
    while (k == 0)
    {
        Console.Write(message);
        int cc = Convert.ToInt32(Console.ReadLine());

        if (checkNum == 0) // любые
        {
            return cc;
        }

        if (cc >= 0 && checkNum == 1) // положительные
        {
            return cc;
        }

        if (cc > 0 && checkNum == 2) // натуральные
        {
            return cc;
        }

        if (cc <= 0 && checkNum == -1) // отрицательные
        {
            return cc;
        }

        Console.WriteLine("Число не соответствует заданному диапазону. Повторите ввод.");
    }
    return 0;
}

double[] CreateArray(double[] arr, int min, int max)
{
    int count = arr.Length;
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < count; i++)
    {
        //2 Console.Write($"Введите {i+1}-й элмент массива -> "); // ручной ввод элементов массива
        //2 arr[i] = Convert.ToDouble(Console.ReadLine());
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    int count = arr.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

// double CheckArray(double[] arr, int check) // суммирование элементов с четными индексами (нечетными местами при выводе)
// {
//     double result = 0;
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         if (check == 1 && arr[i] > +0) result += arr[i];
//         if (check == -1 && arr[i] < 0) result += arr[i];
//     }
//     return result;
// }

double[] GetPosNeg(double[] arr)
{
    double sumPos = 0, sumNeg = 0;
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] >= 0) sumPos += arr[i];
        if (arr[i] < 0) sumNeg += arr[i];
    }
    return new double[] { sumPos, sumNeg };
}



Console.Clear();

int quantity = 12; //Prompt("Введите число элементов массива (натуральное): ", 2);
int min = -9; //Prompt("Укажите минимальный элемент массива (любое): ", 0);
int max = 9; //Prompt("Укажите максимальный элемент массива (любое): ", 0);
double[] array = new double[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
PrintArray(array);

double[] sumPosNeg = GetPosNeg(array);
Console.WriteLine($"Сумма положительных элементов массива равна -> {sumPosNeg[0]}");
Console.WriteLine($"Сумма отрицательных элементов массива равна -> {sumPosNeg[1]}");