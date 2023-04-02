/*9. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8  78 / 10 = 7.8
12-> 2
85 -> 8  8 + 5 % 10 = 5*/

int numberRandom = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberRandom}");
int numberRandom2 = new Random().Next(10, 100); // 99+1
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberRandom2}");
//int firstDigit = numberRandom / 10;
//int secondDigit = numberRandom % 10;

/*if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");
}
*/
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
 //Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");
//Mat.Max(firsDigit, secondDigit);

int maxDigit = MaxDigit (numberRandom);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");
int maxDigit2 = MaxDigit (numberRandom2);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit (int numRandom) //numRandom = numRandom
{
    int firstDigit = numRandom / 10;
    int secondDigit = numRandom % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;    
    return maxDigit;
}