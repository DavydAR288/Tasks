





int xa = Prompt("Введите координату X1: ");
int ya = Prompt("Введите координату Y1: ");
int xb = Prompt("Введите координату X2: ");
int yb = Prompt("Введите координату Y2: ");

double length = Length(xa, ya, xb, yb);
Console.WriteLine($"Расстояние между точками равно {length}");

double Length(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    double s = Math.Sqrt(x * x + y * y);
    double roundS = Math.Round(s, 2, MidpointRounding.ToZero);
    return roundS;
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}