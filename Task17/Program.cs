// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


bool NotZero(int nX, int nY)
{
	if (nX!=0 && nY!=0) return true;
}

int Quarter(int nX, int nY) 
{
	if (nX>0 && ny>0) return 1;
    if (nX<0 && ny>0) return 2;
    if (nX<0 && ny<0) return 3;
    if (nX>0 && ny<0) return 4;
}

int InputXY(string message)
{
    Console.Write(message);
    int nX = Convert.ToInt32(Console.ReadLine());
    return nX;
}

int numX=InputXY("Введите координату Х: ");
int numY=InputXY("Введите координату Y: ");

if (NotZero(numX, numY))
{
    int quartet=Quarter(numX, numY);
    string result = $"Указанные координаты соответствуют четверти {quarter}";
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Одна из координат равна 0. Повторите заново.");
}
Console.WriteLine(numX);


// Console.WriteLine("Введите первое число: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// if (Square(numberOne, numberTwo)) Console.WriteLine("Одно число является квадратом второго");
// else Console.WriteLine("Никакое число не является квадратом другого");


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);    //  условие ? значение : значение
string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти {quarter}"
                : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}