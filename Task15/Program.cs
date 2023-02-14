// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Day(int num)
{
    return num == 6 || num == 7;
}

bool Check(int numCheck)
{
    return numCheck >=1 && numCheck <=7;
}


Console.Write("Введите число от 1 до 7 включительно: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Check(number))
    if (Day(number)) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
else Console.WriteLine("Вы ввели число вне диапазона");