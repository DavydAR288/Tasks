// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

Console.Clear();

int quantity = 4;
int min = 100; 
int max = 999; 
int[] array = new int[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Количество четных чисел в массиве -> {CheckArray(array)}");