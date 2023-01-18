// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = CreateArrayRndDouble(6, -50.0, 50.0);
PrintArrayDouble(arr);

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

double max = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

double min = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
double result = 0;
result = max - min;

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {result}");