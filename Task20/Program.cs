





int xa = Prompt("Введите координату X1: ");
int ya = Prompt("Введите координату Y1: ");
int xb = Prompt("Введите координату X2: ");
int yb = Prompt("Введите координату Y2: ");

double length = Math.Round(Length(xa, ya, xb, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно: {length}");


double Length(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    double result = Math.Sqrt(x * x + y * y);
    return result;
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}