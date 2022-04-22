// Задача 2: Написать программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46

int number = new Random().Next(100, 1000);
int newnumber = 0;
int NumberWithoutSecDig()
{
    newnumber = number / 100 * 10 + number % 10;
    return newnumber;
}
NumberWithoutSecDig();
Console.WriteLine($"Из числа {number} удаляем вторую цифру, и получаем {newnumber}");