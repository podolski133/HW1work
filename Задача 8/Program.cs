// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number, i;

number = 16;
i = 4;

while (i <= number) // либо условие (i <= number -1)
{
    if (i == number) // либо (i == number || i == number -1)
        Console.Write($"{i}. ");
    else
        Console.Write($"{i}, ");
    i = i + 2;
}