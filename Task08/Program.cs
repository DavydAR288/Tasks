// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i, num;

Console.Write("Введите число N: ");
num = Convert.ToInt32(Console.ReadLine());
i = 1;

if (num!=1)
{
    Console.Write($"Четные числа от 1 до {num}: ");
    while (i <= num)
    {
        if (i % 2 == 0) 
        {
            Console.Write($"{i} ");
        }
        i++;
    }
}
else
{
    Console.Write($"Четные числа от 1 до введенного числа N={num} отсутствуют");
}