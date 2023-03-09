// Лекция 7 Рекурсия - дополнительная лекция

Console.Clear();

// Задача 1 собрать строку с числами от a до b, a<=b
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));


// Задача 2 найти сумму чисел от 1 до n
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));


// Задача 3 факториал числа
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10));


// Задача 4 возведение числа а в натуральную степень n
int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;   // тернарный оператор
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(2, 10));
// Математический метод, умножение на само число при четной степени
int PowerRecMath(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;   // тернарный оператор
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10));


// Задача 5 работа с алфавитом и словами из Т букв
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[1]); //5


// Задача 6 работа с директориями, обход паопк и файлов
string pathTest = "D:/_GeekBrains/C/Tasks/_Lecture 7 Help";
DirectoryInfo di = new DirectoryInfo(pathTest);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
//Полное решение
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"D:/_GeekBrains/C/Tasks/_Lecture 7 Help";
CatalogInfo(path);


// Задача 7 игра в пирамидки - Ханойские башни
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();


// Задача 8 обход разных структур ((4-2)*(1+3))/10
// Строим бинарное дерево от операции / деления - номер 1, до чисел 4, 2, 1, 3 с номерами ветвей 8-11 соответственно
// родитель (A индекс i) дочерние (A индекс 2i, A индекс 2i+1)
string emp=string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3", };
//                  0   1    2    3     4    5    6    7    8    9   10   11
void InOrderTraversal(int pos=1)
{
    if (pos<tree.Length)
    {
        int left=2*pos;
        int right=2*pos+1;
        if (left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal(); //разные варианты обхода деревьев - прямой, центрированный, обратный
// практическое применение: HTML, JSON(клиент-сервер), XML(клиент-сервер), разбор выражений, анализ текста, обход графа и т.д.
// в HTML обходом дерева можно ПАРСИТЬ ЧУЖОЙ ИНТЕРНЕТ-МАГАЗИН!


// Использование счетчика времени
DateTime dt=DateTime.Now;
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
