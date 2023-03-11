// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int num1, int num2)
{
    if (num2 == num1) return 0;
    else return num2 + SumRec(num2 - 1, num1);
}


Console.Write("Введите число 1: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberTwo = int.Parse(Console.ReadLine());

Console.WriteLine(SumRec(numberOne, numberTwo));