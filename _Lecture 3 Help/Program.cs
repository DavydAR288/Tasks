// Лекция 3 Lecture 3 help

//Методы

// Вид 1
void Method1()
{
    Console.Writeline("Автор Davyd.AR");
}
Method1(); //Вызов метода

// Вид 2
void Method2(string msg)
{
    Console.Writeline(msg);
}
Method1("Автор Davyd.AR"); //Вызов метода

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Writeline(msg);
        i++;
    }
}
Method1(msg: "Автор Davyd.AR", count: 8); //Вызов метода, можно именованные элементы вызывать не по порядку

// Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3(); //Вызов метода
Console.Writeline(yaer);

// Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
        return result;
    }
}
string res = Method4(8, "Davyd.AR "); //Вызов метода
Console.Writeline(res);

//Цикл for

string Method4(int count, string text)
{
    string result = String.Empty;
    for (i = 0; i < count; i++)
    {
        result = result + text;
        return result;
    }
}
string res = Method4(8, "Davyd.AR "); //Вызов метода
Console.Writeline(res);

//Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.Writeline($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//Задача. Заменить символы в тексте.

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
        + "ежели бы вас послали вместо нашшего любимого Винценгероде,"
        + "вы бы взяли приступом согласие прусского короля. "
        + "Вы так красноречивы. Вы дадите мне чаю?";
// string s= "qwerty"
//            012345
// s[3]=r
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empety;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

//Задача. Упорядочить данные в массиве. Сортировка методом выбора - минимакса.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);

//Задача. Упорядочить данные в массиве. Сортировка от большего к меньшему.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);