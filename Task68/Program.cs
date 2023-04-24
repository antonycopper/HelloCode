﻿/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using System;

class Program {
    static void Main(string[] args) {
        int m = 3;
        int n = 2;
        int result = Ackermann(m, n);
        Console.WriteLine("Результат функции Аккермана({0}, {1}): {2}", m, n, result);
    }

    static int Ackermann(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if (m > 0 && n == 0) {
            return Ackermann(m - 1, 1);
        } else {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}