// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    Console.WriteLine();
    return result;
}

int[] CreateArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число №{i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
}

int SumArray (int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) count+=1;
    }
    return count;
}



Console.Clear();
int num = Promt("Введите число M: ");
if (num <= 0) Console.WriteLine("Введено некорректное число!");
else
{
    int[] array = CreateArray(num);
    int sum = SumArray(array);
    PrintArray(array);
    Console.Write($"; введено положительных чисел -> {sum} ");
}