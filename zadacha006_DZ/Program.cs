/*
Задача №2
Написать программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее
*/

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.Write("Максимальное число: ");
    Console.Write(A);
}
else
{
    Console.Write("Максимальное число: ");
    Console.Write(B);    
}