// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number, i;

number = 16;
i = 4;

while (i <= number)
{
    if (i == number)
        Console.Write($"{i}. ");
    else
        Console.Write($"{i}, ");
    i = i + 2;
}