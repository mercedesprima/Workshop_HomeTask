﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// I Вариант (без цикла, но короче).

// Console.Write("Введите целое число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberB > 0)
// {
//     Console.Write($"{numberA} в степени {numberB} = " + Math.Pow(numberA, numberB));
// }
// else Console.Write("Число B ненатуральное");

// II Вариант.

Console.Write("Введите целое число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;
ToDegree(numberA, numberB);

if (numberB > 0)
Console.WriteLine($"{numberA} в степени {numberB} = " + result);
else Console.Write($"Число {numberB} ненатуральное");

void ToDegree(int numberA, int numberB)
{
    if (numberB > 0)
        for (int i = 1; i <= numberB; i++)
        {
            result = result * numberA;
        }
}

// Console.Write("Введите целое число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberB > 0)
// {
// ToDegree(numberA, numberB);
// void ToDegree(int numA, int numB)
// {
//     int result = 1;
//     for (int i = 1; i <= numB; i++)
//     {
//         result = result * numA;
//     }
//     Console.WriteLine($"{numberA} в степени {numberB} = " + result);
// }
// }
// else Console.Write($"Число {numberB} ненатуральное");