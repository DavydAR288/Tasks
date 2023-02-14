//Ввод 2-х чисел, проверяем остаток от дления первого на второе. Выводим четность либо остаток


Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(numberOne, numberTwo);

if (result == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно, остаток : " + result);

int Multiplicity(int num1, int num2)
{
    int firstDigit = num1 % num2;
    return firstDigit;
}