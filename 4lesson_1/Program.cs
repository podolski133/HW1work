/* Задача 25: Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */

int A = 2;
int B = 4;
int count = 1;
int result = A;

while (count < B)
{
    result = result * A;
    count++;
}
Console.WriteLine($"{A} ^ {B} = {result}");