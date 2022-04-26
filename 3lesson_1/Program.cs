/* Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */ 

Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) Console.WriteLine($"Число: {number} - палиндром");
else Console.WriteLine($"{number} не палиндром");
Console.WriteLine();