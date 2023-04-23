/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = new int[4, 4];
int value = 1;
int height = array.GetLength(0);
int width = array.GetLength(1);

int top = 0;
int bottom = height - 1;
int left = 0;
int right = width - 1;

while (true)
{
    // заполнение сверху слева направо
    for (int i = left; i <= right; i++)
    {
        array[top, i] = value++;
    }

    top++;
    if (top > bottom) break;

    // заполнение справа сверху вниз
    for (int i = top; i <= bottom; i++)
    {
        array[i, right] = value++;
    }

    right--;
    if (right < left) break;

    // заполнение снизу справа налево
    for (int i = right; i >= left; i--)
    {
        array[bottom, i] = value++;
    }

    bottom--;
    if (bottom < top) break;

    // заполнение слева снизу вверх
    for (int i = bottom; i >= top; i--)
    {
        array[i, left] = value++;
    }

    left++;
    if (left > right) break;
}

// вывод массива
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("{0,2} ", array[i, j]);
    }
    Console.WriteLine();
}