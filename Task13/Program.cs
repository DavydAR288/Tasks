// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

bool Check(int numCheck)
{
    return numCheck >= 100 || numCheck<=-100;
}


int Number(int num)
{
    if (num>0)
    {
        while (num>999)
        {
            num=num/10;
        }
        return num % 10;
    }
    else
    {
        while (num<-999)
        {
            num=num/10;
        }
        return num % 10;
    }
}


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Check(number))
    Console.WriteLine($"Третья цифра числа: {Number(number)}");
else
    Console.WriteLine("Третьей цифры нет (число двузначное)");