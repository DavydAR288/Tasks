// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int num1 = Prompt("Введите число (любое): ", 0);
int num2 = Prompt("Введите степень (натуральное): ", 1);
Console.Write($"число {num1} в степени {num2} -> {degreeNum(num1, num2)}");

// Output($"Факториал числа {number} равен", qNum(number));

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

int degreeNum(int a, int b) 
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        checked //проверка на арифметические ошибки вывода
        {
            res = res * a;
        }
    }
    return res;
}

// void Output(string message, int result)
// {
//     Console.WriteLine($"{message} {result}");
// }