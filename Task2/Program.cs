﻿// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Ackermann(FirstNumber, SecondNumber));
