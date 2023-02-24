// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int CheckArray(int[] arr) // суммирование элементов с нечетными индексами (нечетными местами при выводе)
{
    int sum=0;
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (i%2!=0) sum+=arr[i];
    }
    return sum;
}

Console.Clear();

int quantity = 4;
int min = -99; 
int max = 99; 
int[] array = new int[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write($"Сумма элементов на нечетных позициях -> {CheckArray(array)}");