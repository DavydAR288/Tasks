// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Prompt("Введите натуральное число: ");

if (number>0) PrintSqr (number);                                                     //проверка числа на натуральность
else Console.WriteLine("Введено не натуральное число. Начните заново.");

void PrintSqr(int n)                                                                 //невозвратный метод, вывод результата в консоль
{
    Console.WriteLine("Число        Куб числа");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i, 5}            {i*i*i, 5}");
    }
}

int Prompt(string message)                                                          //метод ввода
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}