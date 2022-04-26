/* Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5,0); B (1,-1,9) -> 11.53*/

double xa = 3;
double ya = 6;
double ca = 8;

double xb = 2;
double yb = 1;
double cb = -7;

double S = (xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (ca - cb) * (ca - cb);
S = Math.Sqrt(S);
Console.WriteLine("Расстояние между точками А и В: ");
Console.Write(S);