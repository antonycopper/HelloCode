﻿//Викторина 

int x = 1234;
int a1 = x % 10;
int a2 = x / 10 % 10;
int a3 = x / 100 % 10;
int a4 = x / 1000;
x = a1 * 1000 + a2 * 100 + a3 * 10 + a4;
Console.Write(x == 1);