// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int num1, num2, num3, max;

Console.Write("Введите число #1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число #2: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число #3: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write($"Максимальное число: {max}");