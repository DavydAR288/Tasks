// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();

int quantity = Prompt("Введите число элементов массива (натуральное): ", 1);
int min = Prompt("Укажите минимальный элемент массива (любое): ", 0);
int max = Prompt("Укажите максимальный элемент массива (любое): ", 0);
int[] array = new int[quantity];
array = CreateArray(array, min, max);

PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.Write("]");

int Prompt(string message, int checkNat)
{
    int k = 0; 
    while (k == 0)
    {
        Console.Write(message);
        int cc = Convert.ToInt32(Console.ReadLine());

        if (checkNat == 0)
        {
            k = 1;
            return cc;
        }

        if (cc > 0 && checkNat == 1)
        {
            k = 1;
            return cc;
        }
        else Console.WriteLine("Введено не целое положительное число. Начните заново.");
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