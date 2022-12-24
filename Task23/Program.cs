// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите натуральное число N:   ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    TableSquare(number);
}
else Console.WriteLine("Не натуральное число");
void TableSquare(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 4} {index * index * index, 15}");
        index++;
    }
}