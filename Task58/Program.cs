// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Матрицу P можно умножить на матрицу K только в том случае, 
// если число столбцов матрицы P равняется числу строк матрицы K. Матрицы, 
// для которых данное условие не выполняется, умножать нельзя. 
// Вариант 1. Матрицы заданных размеров. 
// int[,] matrixP = CreateMatrixPRndInt(4, 3, -15, 15);
// PrintMatrix(matrixP);
// Console.WriteLine();
// int[,] matrixK = CreateMatrixKRndInt(3, 2, -15, 15);
// PrintMatrix(matrixK);
// Console.WriteLine();
// int[,] resultMatrix = ResultMatrix(4, 2);
// PrintMatrix(resultMatrix);

// int[,] CreateMatrixPRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrixP = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrixP.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixP.GetLength(1); j++)
//         {
//             matrixP[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrixP;
// }
// int[,] CreateMatrixKRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrixK = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrixK.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixK.GetLength(1); j++)
//         {
//             matrixK[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrixK;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
//             else Console.Write($"{matrix[i, j],5}  ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ResultMatrix(int rows, int columns)
// {
//     int[,] resultMatrix = new int[rows, columns];
//     for (int i = 0; i < matrixP.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrixK.GetLength(1); j++)
//         {
//             resultMatrix[i, j] = 0;
//             for (int k = 0; k < matrixP.GetLength(1); k++)
//             {
//                 resultMatrix[i, j] += matrixP[i, k] * matrixK[k, j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// Вариант 2. Пользовательский ввод размеров матрицы. 

Console.Write("Введите число строк для 1-й матрицы:  ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для 1-й матрицы:  ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк для 2-й матрицы:  ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для 2-й матрицы:  ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrixP = CreateMatrixRndInt(row1, column1);
PrintMatrix(matrixP);
Console.WriteLine();
int[,] matrixK = CreateMatrixRndInt(row2, column2);
PrintMatrix(matrixK);
Console.WriteLine();

if (matrixP.GetLength(1) == matrixK.GetLength(0))
{
    int[,] resultMatrix = ResultMatrix(matrixP, matrixK);
    PrintMatrix(resultMatrix);
}
else Console.WriteLine("Произведение двух матриц выполнить нельзя ");

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-10, 10 + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine();
    }
}

int[,] ResultMatrix(int[,] matrixP, int[,] matrixK)
{
    int[,] resultMatrix = new int[matrixP.GetLength(0), matrixK.GetLength(1)];
    for (int i = 0; i < matrixP.GetLength(0); i++)
    {
        for (int j = 0; j < matrixK.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrixP.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixP[i, k] * matrixK[k, j];
            }
        }
    }
    return resultMatrix;
}