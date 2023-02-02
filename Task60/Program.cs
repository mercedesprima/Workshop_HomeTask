// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Write("Введите размер x :");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер y :");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер z :");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[x, y, z];
Console.WriteLine();

// if ((x * y * z) < -90)
if ((x * y * z) > 90)
{
    Console.WriteLine("Невозможно заполнить массив неповторяющимися двузначными числами. Измените размер массива.");
    return;
}
CreateArray3D(array3D, x, y, z);
Console.WriteLine();
PrintArray3D(array3D);

int[,,] CreateArray3D(int[,,] array, int x, int y, int z)
{
    int numbers = 10;
    // int numbers = - 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = numbers; 
                numbers++;
                // numbers--;
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{k}] ");
            }
        }
        Console.WriteLine();
    }
}