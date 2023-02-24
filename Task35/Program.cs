// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int[] arr, int min, int max)
{
    int count = arr.Length;
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < count; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
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

int CountNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >=10 && arr[i]<=99) count++;
    }
    return count;
}



Console.Clear();

int quantity = 5; 
int min = 0; 
int max = 999; 
int[] array = new int[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
PrintArray(array);

Console.WriteLine($"Количество чисел в отрезке [10, 99] составляет {CountNum(array)}");

