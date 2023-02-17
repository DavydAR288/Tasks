// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int xa = Prompt("Введите координату X1: ");
int ya = Prompt("Введите координату Y1: ");
int za = Prompt("Введите координату Y1: ");
int xb = Prompt("Введите координату X2: ");
int yb = Prompt("Введите координату Y2: ");
int zb = Prompt("Введите координату Y1: ");

double length = Math.Round(Length(xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3-х измерениях равно: {length}");


double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double result = Math.Sqrt(x * x + y * y + z * z);
    return result;
}

int Prompt(string message)
{
    Console.Write(message);
    int cc = Convert.ToInt32(Console.ReadLine());
    return cc;
}