// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3;

Console.Write($"Введите количество чисел: ");
int sizeM = Convert.ToInt32(Console.ReadLine());
int[] arrayM = new int[sizeM];
FillArray(arrayM);
int count = CountPositiveNumbers(arrayM);
PrintArray(arrayM);
Console.WriteLine($" -> 1{count}");

int[] FillArray(int[] arr)
{
    for (int i = 0; i < sizeM; i++)
    {
        Console.Write($"Введите целое число {i + 1}:  ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}