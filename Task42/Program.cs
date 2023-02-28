// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    Console.WriteLine();
    return result;
}

int BinaryNum(int decimalNumber)
{
    var binaryNumber = 0;
    var count = 1;
    while (decimalNumber > 0)
    {
        binaryNumber = binaryNumber + decimalNumber % 2 * count;
        decimalNumber /= 2;
        count *= 10;
    }
    return binaryNumber;
}


int num = Promt("Введите десятичное число: ");
int numB = BinaryNum(num);
Console.WriteLine($"Двоичное число: {numB}");