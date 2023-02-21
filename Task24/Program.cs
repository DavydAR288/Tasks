// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int number = Prompt("Введите целое положительное число: ");

if (number > 0) Console.WriteLine($"Сумма чисел от 1 до {number}: {SumNum(number)}");
else Console.WriteLine("Введено не целое положительное число. Начните заново.");


int Prompt(string message)  //метод ввода, возвращает число
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}

int SumNum(int n)
{
    int res = 0;
    for (int i = 1; i <= n; i++)
    {
        res = res + i;
    }
    return res;
}