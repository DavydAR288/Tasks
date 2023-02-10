// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
int i, num;

Console.Write("Введите натуральное число: ");
num = Convert.ToInt32(Console.ReadLine());
i=-num;

while (i<=num)
{
    Console.Write($"{i} ");
    i++;
}


