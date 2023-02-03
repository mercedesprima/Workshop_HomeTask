// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {m}; n = {n} -> ");

if (m > 0 && n > 0) Console.Write($"A(m,n) = {FunctionAckermann(m, n)} ");
else Console.WriteLine(" Введено ненатуральное число");

int FunctionAckermann(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAckermann(m - 1, 1);
  else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
}
