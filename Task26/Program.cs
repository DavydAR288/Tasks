// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int number = Prompt("Введите целое положительное число: ");

if (number > 0) Output("Количество цифр в введенном числе составляет", CheckNum(number));
else Console.WriteLine("Введено не целое положительное число. Начните заново.");

int Prompt(string message)  //метод ввода, возвращает число
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}

int CheckNum(int n) //метод подсчета количества цифр
{
    int res = 0;
    while (n>0)
    {
        res++;
        n/=10;
    }
    return res;
}

void Output(string message, int result) //метод вывода в консоль
{
    Console.WriteLine($"{message} {result}");
}