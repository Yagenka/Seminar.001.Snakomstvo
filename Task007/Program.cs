// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю
// цифру этого числа.

Console.Write("Введи трехзначное число ");
int N = int.Parse(Console.ReadLine());
double lastnumber = N%10;

  if(lastnumber<0)
    {
         lastnumber=-lastnumber;
    }
 
Console.WriteLine("Последняя цифра числа " + lastnumber);

