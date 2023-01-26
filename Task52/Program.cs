// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = CreateMatrixRndInt(5, 4, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
double[] avgArray = ArithmeticMeanArray(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(avgArray);

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

double[] ArithmeticMeanArray(int[,] matrix)
{
    double[] avgArray = new double[matrix.GetLength(1)];
    double sumColumn = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumColumn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sumColumn += matrix[j, i];
        }
        avgArray[i] = sumColumn / matrix.GetLength(0);
        avgArray[i] = Math.Round(avgArray[i], 1);
    }
    return avgArray;
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
void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
}