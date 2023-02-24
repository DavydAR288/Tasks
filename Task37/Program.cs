// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] NewArray(int[] arr)
{
    int newLength=arr.Length/2;
    if (arr.Length%2!=0) newLength+=1;

    int[] newArray = new int[newLength];

    for (int i = 0; i < newLength; i++)
    {
        newArray[i]=arr[i]*arr[arr.Length-i-1];
    }

    if (arr.Length%2!=0) newArray[newArray.Length-1]=arr[arr.Length/2];
    return newArray;
}

Console.Clear();

int quantity = 5; 
int min = 0; 
int max = 10; 
int[] array = new int[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
PrintArray(array);

Console.Write("Массив произведений -> ");
PrintArray(NewArray(array));


