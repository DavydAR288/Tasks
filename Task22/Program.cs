// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int number = Prompt("Введите число: ");

if (number>0) PrintSqr (number);
else Console.WriteLine("Повторите ввод, введено не натуральное число.");

void PrintSqr(int n) 
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}      {i*i}");
    }
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}