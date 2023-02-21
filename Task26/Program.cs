// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int number = Prompt("Введите целое положительное число: ");

if (number > 0) Console.WriteLine($"Количество цифр в числе {number} составляет {CheckNum(number)}");
else Console.WriteLine("Введено не целое положительное число. Начните заново.");


int Prompt(string message)  //метод ввода, возвращает число
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}

int CheckNum(int n) 
{
    int res = 0;
    while (n>0)
    {
        res++;
        n=n/10;
    }
    return res;
}