// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int Prompt(string message, int checkNum) // checkNum: -1 отрицательные; 0 любые; 1 положительные; 2 натуральные;
// {
//     int k = 0;
//     while (k == 0)
//     {
//         Console.Write(message);
//         int cc = Convert.ToInt32(Console.ReadLine());

//         if (checkNum == 0) // любые
//         {
//             return cc;
//         }

//         if (cc >= 0 && checkNum == 1) // положительные
//         {
//             return cc;
//         }

//         if (cc > 0 && checkNum == 2) // натуральные
//         {
//             return cc;
//         }

//         if (cc <= 0 && checkNum == -1) // отрицательные
//         {
//             return cc;
//         }

//         Console.WriteLine("Число не соответствует заданному диапазону. Повторите ввод.");
//     }
//     return 0;
// }

double[] CreateArray(double[] arr, int min, int max)
{
    int count = arr.Length;
    Random rnd = new Random(); //создает псевдослучайное число по системному времени 15мс
    for (int i = 0; i < count; i++)
    {
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

void ModifyArray(double[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        arr[i]*=(-1);
    }
}

Console.Clear();

int quantity = 10;
int min = -10;
int max = 10;

double[] array = new double[quantity];
array = CreateArray(array, min, max);

Console.Write("Массив -> ");
PrintArray(array);

Console.WriteLine();
Console.Write("Измененный массив -> ");
ModifyArray(array);
PrintArray(array);
