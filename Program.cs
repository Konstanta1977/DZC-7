// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double getDoubleByDivision(int a, int b)
// {
//     if (b == 0)
//     {
//         b = 1;
//     }
//     return Convert.ToDouble(a) / Convert.ToDouble(b);
// }
// double getRandomDouble()
// {
//     Random rnd = new Random();
//     return getDoubleByDivision(
//         rnd.Next(-10, 11),
//         rnd.Next(-10, 11)
//     );
// }
// void fillMatrixWithRandomDoubles(double[,] matrix)
// {
//     for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
//     {
//         for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
//         {
//             matrix[rowIndex, columnIndex] = getRandomDouble();
//         }
//     }
// }
// void printMatrixToConsole(double[,] matrix)
// {
//     for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
//     {
//         Console.Write("\n");
//         for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
//         {
//             Console.Write($" {String.Format("{0:F1}", matrix[rowIndex, columnIndex])}");
//         }
//     }
// }
// Console.WriteLine("Введите количество строк матрицы");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов матрицы");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m < 1 || n < 1)
// {
//     Console.WriteLine("Некорректные значения");
// }
// else
// {
//     double[,] matrix = new double[m, n];

//     fillMatrixWithRandomDoubles(matrix);
//     printMatrixToConsole(matrix);
// }

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void fillMatrixWithRandomIntegers(int[,] matrix)
{
    Random rnd = new Random();
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            matrix[rowIndex, columnIndex] = rnd.Next(-10, 11);
        }
    }
}
void printMatrixOfIntegersToConsole(int[,] matrix)
{
    for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
    {
        Console.Write("\n");
        for (int columnIndex = 0; columnIndex < matrix.GetLength(1); columnIndex++)
        {
            Console.Write($"  {matrix[rowIndex, columnIndex]}");
        }
    }
    Console.Write("\n");
}
Console.WriteLine("Введите количество строк матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 1 || n < 1)
{
    Console.WriteLine("Некорректные значения");
}
else
{
    int[,] matrix = new int[m, n];
    fillMatrixWithRandomIntegers(matrix);
    printMatrixOfIntegersToConsole(matrix);
    int pos = 1;
    while (pos >= 0)
    {
        Console.WriteLine("Введите позицию искомого элемента. Для выхода введите значение меньше единицы");
        pos = Convert.ToInt32(Console.ReadLine());
        if (pos < 1)
        {
            break;
        }

        int size = m * n;
        if (pos > size)
        {
            Console.WriteLine("такого числа в массиве нет");
        }
        else
        {
            pos--; 
            int row = pos / n;
            int col = pos - (n * row);

            Console.WriteLine($"значение элемента под индексами {row} {col} равно {matrix[row, col]}");
        }
    }
}
