/*Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.*/

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");

int SumNumbers(int num)   // - это вход в программу
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;           //  - это выход, 
                          // который невидимо стрелочкой возвращает нас
                          // в int result (8 строка)
                          // в полученный результат и выводит в консоль.
                          // то есть полученное значение в 
                          // (SumNumbers(number)), с помощью знака =
                          // присваивает в int result  и выводит уже,
                          // с помощью строки Console.WriteLine.
}