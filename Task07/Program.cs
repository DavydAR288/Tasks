// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
int i;
double num, c;
i = 0;

do
{
    Console.Write("Введите трехзначное число: ");
    num = Convert.ToDouble(Console.ReadLine());
    if (num >= 100 && num <= 999)
    {
        i = 1;
    }
    else
    {
        Console.WriteLine("Вы ввели НЕ трехзначное число!");
    }
}
while (i == 0);

c = num % 10;
Console.WriteLine($"Последняя цифра числа {num} = {c}");