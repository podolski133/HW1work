﻿// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// Пример:
// 2, 3, 7 -> 7
int numberA, numberB, numberC;
int max;

numberA = 45;
numberB = 9;
numberC = 79;

max = numberA;

if (max > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
if (max > numberC)
{
    max = numberA;
}
else
{
    max = numberC;
}
System.Console.WriteLine(max);