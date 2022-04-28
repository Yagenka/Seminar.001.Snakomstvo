// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int numC = int.Parse(Console.ReadLine());

int max = numA;
if (numB > max)  max = numB;
if (numC > max)  max = numC;

Console.Write("Максимальное из этих чисел - ");
Console.WriteLine(max);
