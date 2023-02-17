// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = Prompt("Введите натуральное число: ");

if (number > 0) Palindrome(number); //проверка числа на натуральность
else Console.WriteLine("Введено не натуральное число. Начните заново.");

void Palindrome(int num)    //невозвратный метод, вывод результата в консоль
{
    int numX=0;
    int numOriginal=num;
    while (num>0)   //разворот числа
    {
        numX=numX*10+num%10;
        num/=10;
    }

    if (numOriginal==numX) Console.WriteLine($"Число {numOriginal} является палиндромом");
    else Console.WriteLine($"Число {numOriginal} НЕ является палиндромом");
}

int Prompt(string message)  //метод ввода
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}

