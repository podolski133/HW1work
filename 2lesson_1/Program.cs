// Задача 1: Написать программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую цифру
// этого числа.
// 456 -> 5

int a = 456;
int a1 = a % 10;
int a2 = (a - a1) / 10 % 10;
Console.WriteLine(a2);