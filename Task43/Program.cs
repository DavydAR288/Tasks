// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    double result = Convert.ToInt32(value);
    // Console.WriteLine();
    return result;
}

double[] FindXY(double b1, double k1, double b2, double k2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2); 
    arr[1] = (b1*k2-b2*k1)/(k2-k1);
    return arr;
}

void PrintXY(double[] arrayXY)
{
    var roundX = Math.Round(arrayXY[0], 1, MidpointRounding.ToZero); 
    var roundY = Math.Round(arrayXY[1], 1, MidpointRounding.ToZero);
    Console.Write($"Координаты точки пересечения двух прямых: ({roundX}; {roundY})");
}



Console.Clear();
Console.WriteLine($"Введите b1, k1, b2 и k2 для уравнений y = k1 * x + b1, y = k2 * x + b2");
double numB1 = Promt("b1 = ");
double numK1 = Promt("k1 = ");
double numB2 = Promt("b2 = ");
double numK2 = Promt("k2 = ");
double[] arrayResult = FindXY(numB1, numK1, numB2, numK2);
PrintXY(arrayResult);


