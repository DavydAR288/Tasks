// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int quantity = Prompt("Введите число элементов массива (натуральное): ", 2);
int min = 0; //Prompt("Укажите минимальный элемент массива (любое): ", 0);
int max = 99; //Prompt("Укажите максимальный элемент массива (любое): ", 0);
double[] array = new double[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Разница между максимальным и минимальным элементами массива -> {CheckArray(array)}");

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
        arr[i]=rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

double CheckArray(double[] arr) // суммирование элементов с четными индексами (нечетными местами при выводе)
{
    double sum = 0, max = arr[0], min = arr[0];
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    sum = max - min;
    return sum;
}