//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

int nubmer = Convert.ToInt32(Console.ReadLine());

/*
Можно через if:

if (nubmer == 1)
{
    Console.WriteLine("Понедельник");
}
else if (nubmer == 2)
{
    Console.WriteLine("Вторник");
}
else if (nubmer == 3)
{
    Console.WriteLine("Среда");
}
else if (nubmer == 4)
{
    Console.WriteLine("Четверг");
}
else if (nubmer == 5)
{
    Console.WriteLine("Пятница");
}
else if (nubmer == 6)
{
    Console.WriteLine("Суббота");
}
else if (nubmer == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Неверное число");
}

так же можно через:
*/

switch (nubmer)
{
    case 1:
            Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    default:
        Console.WriteLine("Только 7 дней в неделе!");
        break;
}