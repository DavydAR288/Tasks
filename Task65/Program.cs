// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.WriteLine("Введите натуральное число:");
// int number = int.Parse(Console.ReadLine());
// NaturalNumbers(number);

// void NaturalNumbers(int num)    // любая рекурсия сохраняет результат в стэк, поэтому значения берутся от последнего результата
// {
//     if (num == 0) return;       // выход из рекурсии, не из метода
//     NaturalNumbers(num - 1);
//     Console.Write($"{num} ");
// }


// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else if (a > b) return $"{b} " + NumbersRec(a, b + 1);
//     else return String.Empty;
//     // if (a >= b) return $"{b} " + NumbersRec(a, b + 1);
//     //if (a == b) return String.Empty;
// }

// Console.Write("Введите натуральное число M: ");
// int numberM = int.Parse(Console.ReadLine());
// Console.Write("Введите натуральное число N: ");
// int numberN = int.Parse(Console.ReadLine());

// Console.WriteLine(NumbersRec(numberM, numberN));



Console.WriteLine("Введите число M");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberTwo = int.Parse(Console.ReadLine());
PrintNumber(numberOne, numberTwo);

void PrintNumber(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        PrintNumber(num1 - 1, num2);
    }
    else if (num2 > num1)
    {
        PrintNumber(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else 
    {
        Console.Write($"{num2} ");
    }
}