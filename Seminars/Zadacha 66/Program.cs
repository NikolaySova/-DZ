﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 4;
int N = 8;
int sum = 0;

void PrintNaturalNumbers(int m, int n)
{
    if (n < m) return;
    sum = sum + n;
    PrintNaturalNumbers(m, n - 1);

}

PrintNaturalNumbers(M, N);
Console.Write($"{sum} ");