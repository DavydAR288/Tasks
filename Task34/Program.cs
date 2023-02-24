// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int quantity = Prompt("Введите число элементов массива (натуральное): ", 2);
int min = 100; //Prompt("Укажите минимальный элемент массива (любое): ", 0);
int max = 999; //Prompt("Укажите максимальный элемент массива (любое): ", 0);
int[] array = new int[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Количество четных чисел в массиве -> {CheckArray(array)}");

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

int[] CreateArray(int[] arr, int min, int max)
{
    int count = arr.Length;
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < count; i++)
    {
        arr[i]=rnd.Next(min,max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int CheckArray(int[] arr) // суммирование четных чисел
{
    int sum=0;
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i]%2==0) sum++;
    }
    return sum;
}