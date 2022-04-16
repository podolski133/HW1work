int numberA, numberB, numberC;
int max;

numberA = 44;
numberB = 5;
numberC = 78;

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