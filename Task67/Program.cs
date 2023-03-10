// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
//  {
//      if (n == 1) return 1;
//      else return n * FactorialRec(n - 1);
//  }
//  Console.WriteLine(FactorialRec(10)); // 3628800

int PowerRecMath(int num)
{
    if (num == 0) return 0;
    else return num % 10 + PowerRecMath(num / 10); // 453, 453/10, 45/10, 4/10 > сначала происходят рекрсивные вызовы!!!

}

Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"Сумма цифр числа {number} > ");
Console.WriteLine(PowerRecMath(number));