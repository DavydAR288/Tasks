// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int Promt(string message)
{
    Console.Write(message);
    string value = (Console.ReadLine());
    int result = Convert.ToInt32(value);
    Console.WriteLine();
    return result;
}

bool TriangleExist(int numA, int numB, int numC)
{
    return numA<numB+numC && numB<numA+numC && numC<numB+numA;
}



int sizeA = Promt ("Введите сторону А: ");
int sizeB = Promt ("Введите сторону B: ");
int sizeC = Promt ("Введите сторону C: ");

bool exist= TriangleExist(sizeA, sizeB, sizeC);

if (exist) Console.WriteLine("Треугольник с введенными сторонами существует");
else Console.WriteLine("Треугольник с введенными сторонами не существует");
