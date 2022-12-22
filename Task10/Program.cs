// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзнаяное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(100,1000);

int secondDigit = (number / 10) % 10;

int result = secondDigit;
Console.WriteLine($"Результат из {number} -> {result}");