// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int NaturalNumbers(int num1, int num2)  
{
    if (num1<num2)
    {
        if(num2==num1) return num1;
        return num2 + NaturalNumbers(num1,num2-1);
    }
    else
    {
        if(num1==num2) return num2;
        return num1 + NaturalNumbers(num2,num1-1);
    }
}

Console.Write("Введите натуральное число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число 2: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(NaturalNumbers(number1, number2));