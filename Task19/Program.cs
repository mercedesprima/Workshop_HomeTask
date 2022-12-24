// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int Length = number.Length;

if (Length == 5)
{

   if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} является палиндромом");
    }

else
    {
        Console.WriteLine($"{number} не является палиндромом");
    }
}
      else
    {
        Console.WriteLine($"{number} не является пятизначным");
    }


