﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// A(m, n)  = n + 1, если m = 0,
//          = A(m - 1, 1), если m > 0, n = 0,
//          = A(m - 1, A(m, n - 1)), если m > 0, n > 0.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите число m>0: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число n>0: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 >= 0 && number2 >= 0) Console.WriteLine($"Значение функции Аккермана для введенных чисел равно: {Akkerman(number1, number2)}");
else Console.WriteLine("Ошибка ввода");