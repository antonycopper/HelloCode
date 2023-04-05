/*Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("Введите номер четверти");
string numQuart = Console.ReadLine();

string result = Quarter(numQuart);

Console.WriteLine(result);
string Quarter(string numQuart)
{
    if (numQuart == "1") return "x > 0; y > 0";
    if (numQuart == "2") return "x < 0; y > 0";
    if (numQuart == "3") return "x < 0; y < 0";
    if (numQuart == "4") return "x > 0; y < 0";
    return "error";
}