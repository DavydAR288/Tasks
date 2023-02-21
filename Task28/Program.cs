// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int number = Prompt("Введите целое положительное число: ");

Output($"Факториал числа {number} равен", qNum(number));

int Prompt(string message)  //метод ввода, возвращает число
{
    int k=0;
    while (k==0)
    {
        Console.Write(message);
        int cc = Convert.ToInt32(Console.ReadLine());
        if (cc>0)
        {
            k=1;
            return cc;
        }
        else Console.WriteLine("Введено не целое положительное число. Начните заново.");
    }
    return 0;
}

int qNum(int n) 
{
    int res = 1;
    for (int i = 1; i <= n; i++)
    {
        checked //проверка на арифметические ошибки вывода
        {
            res =res* i;
        }
    }
    return res;
}

void Output(string message, int result)
{
    Console.WriteLine($"{message} {result}");
}