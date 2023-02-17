// Задача 18: Напишите программу, 
// 1. которая по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = QuarterFind(quarter);
if (quarter > 0 && quarter < 5)
{
    Console.WriteLine($"В указанной четверти координаты соответствуют следующим диапазонам: {result}");
}
else Console.WriteLine($"Четверть введена некоректно");

string QuarterFind(int q)
{
    if (q == 1) return "X>0, Y>0";
    if (q == 2) return "X<0, Y>0";
    if (q == 3) return "X<0, Y<0";
    if (q == 4) return "X>0, Y<0";
    return "";
}

