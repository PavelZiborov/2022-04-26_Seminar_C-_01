/*
Задача №4
Написать программу, которая принимает на вход 3 числа и выдает максимальное из них
*/

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A >= B & A >= C)
{
    Console.Write("Самое больше число: ");
    Console.Write(A);
}
else if (B >= A & B >= C)
{
    Console.Write("Самое больше число: ");
    Console.Write(B);
}
else if (C >= A & C >= B)
{
    Console.Write("Самое больше число: ");
    Console.Write(C);
}