// // Задача 29. Напишите программу, которая 
// // задаёт массив из 8 элементов и 
// // выводит их на экран.
// // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = CreateArray(8);
PrintArray(array);
Console.Write($" -> [");
PrintArray(array);
Console.Write($"]");
int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 99);  // int.MaxValue
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write(i < arr.Length -1 ? arr[i] + ", " : arr[i]);
    }
}