// Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

int num = int.Parse(Console.ReadLine());

bool chetnoe = num%2 == 0;
Console.WriteLine (chetnoe ? "Да" : "Нет");