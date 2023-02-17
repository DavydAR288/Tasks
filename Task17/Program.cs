// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


bool NotZero(int nX, int nY)
{
    if (nX != 0 && nY != 0) return true;
    return false;
}

int Quarter(int nX, int nY)
{
    if (nX > 0 && nY > 0) return 1;
    if (nX < 0 && nY > 0) return 2;
    if (nX < 0 && nY < 0) return 3;
    if (nX > 0 && nY < 0) return 4;
    return 0;
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}

int numX = Prompt("Введите координату Х: ");
int numY = Prompt("Введите координату Y: ");

if (NotZero(numX, numY))
{
    int quarter = Quarter(numX, numY);
    Console.WriteLine($"Указанные координаты соответствуют четверти {quarter}");
}
else
{
    Console.WriteLine("Одна из координат равна 0. Повторите заново.");
}


// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int xc = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yc = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(xc, yc);    //  условие ? значение : значение
// string result = quarter > 0 
//                 ? $"Указанные координаты соответствуют четверти {quarter}"
//                 : "Введены некорректные координаты";
// Console.WriteLine(result);

// int Quarter(int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;
//     return 0;
// }