// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty;
// }
// Console.WriteLine(NumbersRec(1, 10));

Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers(int num)    // любая рекурсия сохраняет результат в стэк, поэтому значения берутся от последнего результата
{
    if (num == 0) return;       // выход из рекурсии, не из метода
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
