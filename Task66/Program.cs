/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 4;
        int n = 8;
        int sum = SumNumbers(m, n);
        Console.WriteLine("Сумма чисел от {0} до {1}: {2}", m, n, sum);
    }

    static int SumNumbers(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        return m + SumNumbers(m + 1, n);
    }
}