﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю
// цифру этого числа.

Console.Write("Введи трехзначное число ");
int N = int.Parse(Console.ReadLine());
double ostatok = N%10;
 
Console.WriteLine("Последняя цифра числа " + ostatok);

