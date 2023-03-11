// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


String Recursion(int num)
{
    if (num == 0) return string.Empty;
    return num + " " + Recursion(num - 1);
}

Console.Write("Введите натуральное число: ");
int number = int.Parse(Console.ReadLine());
if (number>0) Console.Write(Recursion(number));
else Console.Write("Ошибка ввода");