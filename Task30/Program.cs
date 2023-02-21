// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

int[] array = new int[8];
CreateArray(array);
PrintArray(array);

void CreateArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i]=new Random().Next(0,2);
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}