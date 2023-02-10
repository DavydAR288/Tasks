// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num1, num2;

Console.Write("Введите число #1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число #2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 != num2)
{
    if (num1>num2)
    {
        Console.Write($"Из двух введенных чисел большим является первое число {num1}");
    }

    else
    {
        Console.Write($"Из двух введенных чисел большим является второе число {num2}");
    }
}
else
    {
        Console.Write("Введенные числа равны");
    }