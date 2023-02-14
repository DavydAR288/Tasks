// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Число в диапазоне 100-999: {number}");

int newNumber = NewNumber(number);
Console.WriteLine($"Новое число, полученное из первой и последней цифры случайного числа - {newNumber}");

int NewNumber(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;

    return result;
}