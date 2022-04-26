/*
Задача 4: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
if (A >= 2)
{
    for (int i = 2; i <= A; i++)
    {
        if (i%2 == 0)
        {
            Console.Write(i+" ");
        }
    }
}
else
{
    Console.Write("Введите целое число больше 1");
}