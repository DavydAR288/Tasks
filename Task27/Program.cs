// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int number = Prompt("Введите число (натуральное): ", 1);
Console.Write($"В числе {number} сумма цифр -> {SumDigit(number)}");

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

int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        checked //проверка на арифметические ошибки вывода
        {
            res = res + num % 10;
            num = num / 10;
        }
    }
    return res;
}

// void Output(string message, int result)
// {
//     Console.WriteLine($"{message} {result}");
// }