// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// A(m, n)  = n + 1, если m = 0,
//          = A(m - 1, 1), если m > 0, n = 0,
//          = A(m - 1, A(m, n - 1)), если m > 0, n > 0.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите число m: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана для введенных чисел равно: {Akkerman(number1, number2)}");