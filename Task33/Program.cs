// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNum(double[] arr, int number)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}



Console.Clear();

int quantity = 10; 
int min = -999; 
int max = 999; 
double[] array = new double[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
PrintArray(array);

int number = Prompt("Введите искомое число (любое): ", 0);

if (FindNum(array, number) == true) Console.WriteLine($"Искомое число найдено");
else Console.WriteLine($"Искомое число не найдено");



// int Prompt(string message)
// {
//     Console.Write(message);
//     int cc = Convert.ToInt32(Console.ReadLine());
//     return 0;
// }

// int[] CreateArray(int[] arr, int min, int max)
// {
//     int count = arr.Length;
//     Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
//     for (int i = 0; i < count; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     int count = arr.Length;
//     Console.Write("[");
//     for (int i = 0; i < count; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// bool FindNum(inte[] arr, int number)
// {
//     int count = arr.Length;
//     for (int i = 0; i < count; i++)
//     {
//         if (arr[i] == number) return true;
//     }
//     return false;
// }

// Console.Clear();
// int quantity = 10; 
// int min = -999; 
// int max = 999; 
// int[] array = new int[quantity];
// array = CreateArray(array, min, max);
// Console.Write("Массив -> ");
// PrintArray(array);
// int number = Prompt("Введите искомое число: ");
// if (FindNum(array, number) == true) Console.WriteLine($"Искомое число найдено");
// else Console.WriteLine($"Искомое число не найдено");