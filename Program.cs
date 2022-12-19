// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}