// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int number = Prompt("Введите целое положительное число: ");

if (number > 0) Output($"Сумма чисел от 1 до {number} ", qNum(number));
else Console.WriteLine("Введено не целое положительное число. Начните заново.");

int Prompt(string message)  //метод ввода, возвращает число
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
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

void Output(string message, int result) //метод вывода в консоль
{
    Console.WriteLine($"{message} {result}");
}