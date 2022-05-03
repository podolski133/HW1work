/* Задача 27: Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int number = new Random().Next(1, 10000);
int sum = 0;
Console.Write($"Сумма цифр числа {number} равна ");
while (number > 0)
{
    int sum1 = number % 10;
    sum = sum + sum1;
    number = number / 10;
}
Console.WriteLine(sum);