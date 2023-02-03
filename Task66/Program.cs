// Задача 66: Задайте значения M и N. 
//Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число :");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число :");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {numberM}; N = {numberN} -> ");

int result = NaturalNumbersSum(numberM, numberN);
if (numberM > 0 && numberN > 0) Console.Write(result);
else Console.WriteLine(" Введено ненатуральное число");

int NaturalNumbersSum(int numM, int numN)
{
    if (numM > numN) return numM + NaturalNumbersSum(numM-1, numN);
    if (numM < numN) return numM + NaturalNumbersSum(numM+1, numN);
    if (numM == numN) return numM; 
    return numM;
}

