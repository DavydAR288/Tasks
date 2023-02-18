// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Prompt("Введите натуральное число: ");

if (number > 0) //проверка числа на натуральность
{
    Output(Palindrome(number), number); //вызов метода проверки на палиндром и вызов невозвратного метода вывода результата проверки в консоль
}
else Console.WriteLine("Введено не натуральное число. Начните заново.");

bool Palindrome(int num)    //метод проверки палиндрома, возвращает истина/ложь
{
    int numX = 0;
    int numOriginal = num;
    while (num > 0)   //разворот числа
    {
        numX = numX * 10 + num % 10;
        num /= 10;
    }

    if (numOriginal == numX) return true;
    else return false;
}

int Prompt(string message)  //метод ввода, возвращает число
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}

void Output (bool inputRes, int numOriginal) //невозвратный метод вывода в консоль, получает истину/ложь и число
{
    if (inputRes) Console.WriteLine($"Число {numOriginal} является палиндромом");
    else Console.WriteLine($"Число {numOriginal} НЕ является палиндромом");
}

