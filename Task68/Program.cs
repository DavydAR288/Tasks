// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//
// A(m, n)  = n + 1, если m = 0,
//          = A(m - 1, 1), если m > 0, n = 0,
//          = A(m - 1, A(m, n - 1)), если m > 0, n > 0.

public class Solution {
    public static int recursion(int m, int n) {
        // Базовый случай
        if (m == 0) {
            return n + 1;
        } // Шаг рекурсии / рекурсивное условие
        else if (n == 0 && m > 0) {
            return recursion(m - 1, 1);
        } // Шаг рекурсии / рекурсивное условие
        else {
            return recursion(m - 1, recursion(m, n - 1));
        }
    }
    public static void main(String[] args) {
        System.out.println(recursion(3, 2)); // вызов рекурсивной функции
    }
}