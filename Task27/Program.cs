// Задача 27: Напишите программу, 
// которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int size = CountNumbers(number);
SumNumbers(number, size);

int CountNumbers(int digit)
{
    int count = 0;

    while (digit != 0)
    {
       digit = digit / 10;
       count++;
    }
    return count;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + n % 10;
        n = n/10;
    }
    Console.WriteLine($"Cумма цифр введенного числа:  {sum}");
}
