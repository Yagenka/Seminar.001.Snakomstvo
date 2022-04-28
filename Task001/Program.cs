// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.


int numA = int.Parse(Console.ReadLine ());
int numB = int.Parse(Console.ReadLine ());

if (numA < numB) 
{ 
Console.Write ("max = ");
Console.WriteLine(numB);
Console.Write ("min = ");
Console.WriteLine(numA);
}
else
{
Console.Write ("max =");
Console.WriteLine(numA);
Console.Write ("min = ");
Console.WriteLine(numB);

}