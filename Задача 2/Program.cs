// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int numberA, numberB;
int max;

numberA = 5;
numberB = 7;

max = numberA;

if (max > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
Console.WriteLine(max);