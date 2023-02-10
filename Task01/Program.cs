// Задача 1
// Проверяем, является ли первое число квадратом вторго

int num1, num2;

Console.Write("Введите число #1: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число #2: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1==num2*num2)
{
    Console.Write($"Число {num1} является квадратом числа {num2}");
}

else
{
    Console.Write($"Число {num1} не является квадратом числа {num2}");
}