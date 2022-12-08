// 1. Задача 47 - раскомментировать строки 51 - 77.
// 2. Задача 50 - раскомментировать строки 5 - 47 и 87 - 105.
// 3. Задача 52 - раскомментировать строки 5 - 47 и 114 - 135.

/*
void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
*/


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().NextDouble(), 1) + new Random().Next(minValue, maxValue);

    return array;
}

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArrayDouble(m, n, min, max);
Show2dArrayDouble(myArray);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

/*
void FindElement(int i, int j, int[,] array)
{
    if(i < array.GetLength(0) & j < array.GetLength(1))
        Console.WriteLine($"The element at position i = {i}, j = {j} is {array[i, j]}");
    else 
        Console.WriteLine($"There is no element at position i = {i}, j = {j}");
}

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.Write("Input row number i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column number j: ");
int j = Convert.ToInt32(Console.ReadLine());

FindElement(i, j, myArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
double[] AverageOfColumn(int[,] array)
{
    double[] aveCol = new double[array.GetLength(1)];
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        
        aveCol[j] = Math.Round((sum / array.GetLength(0)), 1);
    }
    return aveCol;
}

int[,] my2dArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(my2dArray);
double[] newArray = AverageOfColumn(my2dArray);
ShowDoubleArray(newArray);
*/

