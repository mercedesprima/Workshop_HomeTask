// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = CreateArrayRndDouble(6, -50.0, 50.0);
PrintArrayDouble(arr);
double maxArr = MaxArr(arr);
double minArr = MinArr(arr);
double result = DiffMaxMin(maxArr, minArr);


Console.WriteLine($"Максимальное число: {maxArr}");
Console.WriteLine($"Минимальное число: {minArr}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {maxArr - minArr}");

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

double MaxArr(double[] arr)
{
    double maxArr = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxArr)
        {
            maxArr = arr[i];
        }
    }
    return maxArr;
}

double MinArr(double[] arr)
{
    double minArr = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minArr)
        {
            minArr = arr[i];
        }
    }
    return minArr;
}

double DiffMaxMin(double min, double max)
{
double result = 0;
result = maxArr - minArr;
result = Math.Round(result, 1);
return result;
}


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