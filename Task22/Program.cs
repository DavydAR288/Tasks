// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = Prompt("Введите натуральное число: ");

if (number>0) PrintSqr (number);
else Console.WriteLine("Введено не натуральное число. Начните заново.");

void PrintSqr(int n) 
{
    Console.WriteLine("Число        Квадрат числа");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}            {i*i}");
    }
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}