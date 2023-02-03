// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Write("Введите номер строки:  ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца:  ");
int column = Convert.ToInt32(Console.ReadLine());

if (row > 0 && column > 0)
{
    int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
    PrintMatrix(matrix);
    if (row <= matrix.GetLength(0) + 1 && column <= matrix.GetLength(1) + 1)
        Console.WriteLine($"строка {row}, столбец {column} -> {matrix[row - 1, column - 1]}");
    else Console.WriteLine("Такого элемента в массиве нет");
}
else Console.WriteLine("И номер строки, и номер столбца должны быть больше 0.");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}
//   Вариант с переменной в цикле. 

// int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
// TestNatural(matrix);
// PrintMatrix(matrix);

// void TestNatural (int[,] matrix)
// { 
//     while (true)
//     {
//         Console.WriteLine("Введите номер строки: ");
//         int row = Convert.ToInt32(Console.ReadLine());
//         if (row <= 0) Console.WriteLine("Введите число больше 0");
//         else break;
//     }
//     while (true)
//         {
//             Console.WriteLine("Введите номер столбца: ");
//             int column = Convert.ToInt32(Console.ReadLine());
//             if (column <= 0) Console.WriteLine("Введите число больше 0");
//             else break;
//             // return column;
//             // CreateMatrixRndInt(8, 7, 1, 50); 
//         }
// }
//     if (row <= matrix.GetLength(0) + 1 && column <= matrix.GetLength(1) + 1)
//                 Console.WriteLine($"строка {row}, столбец {column} -> {matrix[row - 1, column - 1]}");

//             else Console.WriteLine("И номер строки, и номер столбца должны быть больше 0.");

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
//             else Console.Write($"{matrix[i, j],5}  ");
//         }
//         Console.WriteLine("]");
//     }
// }