// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (Square(numberOne, numberTwo)) Console.WriteLine("Одно число является квадратом второго");
else Console.WriteLine("Никакое число не является квадратом другого");

bool Square(int num1, int num2)
{
	return num1 * num1 == num2 || num2 * num2 == num1;
}