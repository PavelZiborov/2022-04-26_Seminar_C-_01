// Решить задачу умножения задананного числа само на себя

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 - Конвертирует строку в целые числа
int result = number * number;
Console.WriteLine(result);