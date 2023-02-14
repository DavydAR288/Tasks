// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

bool Check(int numCheck)
{
    return numCheck >= 100 && numCheck <= 999;
}


int Number(int num)
{
    return num / 10 % 10;
}


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Check(number))
    Console.WriteLine($"Вторая цифра числа: {Number(number)}");
else
    Console.WriteLine("Вы ввели не трёхзначное число");
