
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


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
void MaxToMinInRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                if (array[i, k] < array[i, k+1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }            
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
MaxToMinInRows(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
void RowMinSumElements(int[,] array)
{
    int[] rowArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            rowArray[i] += array[i, j];

    int min = rowArray[0];
    int imin = 0;
    for (int i = 1; i < rowArray.Length; i++)
        if (rowArray[i] < min)
        {
            min = rowArray[i];
            imin = i;
        }
    Console.WriteLine($"The row number with the minimum sum of elements is {imin + 1}");
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
RowMinSumElements(myArray);
*/


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] multiArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
            for (int j = 0; j < array2.GetLength(1); j++)
                for (int k = 0; k < array1.GetLength(1); k++)
                    multiArray[i, j] += array1[i, k] * array2[k, j];
        return multiArray;
    }
    else return multiArray = new int[1,1];    
}

Console.Write("Input a number of rows first array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns first array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value first array: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value first array: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows second array: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns second array: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value second array: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value second array: ");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = CreateRandom2dArray(m, n, min1, max1);
Show2dArray(array1);
int[,] array2 = CreateRandom2dArray(k, l, min2, max2);
Show2dArray(array2);
int[,] resultArray = MatrixMultiplication(array1, array2);
Show2dArray(resultArray);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateRandom3dArray(int rows, int columns, int z, int minValue, int maxValue)
// {
//     int[,,] array = new int[rows, columns, z];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < z; k++)
//                 array[i, j, k] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

/*
void Show3dArrayWithIndexes(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] Unic(int rows, int columns, int z, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, z];
    if (rows * columns * z <= 90) //задать 90 не как магию а как количество двузначных чисел 
    {  
        array[0, 0, 0] = new Random().Next(minValue, maxValue + 1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    array[i, j, k] = new Random().Next(minValue, maxValue + 1);
                    if (array[i, j, k] == array[i, j, k - 1]) k--;
                }
                if (array[i, j, k] == array[i, j - 1, k]) j--;
            }
            if (array[i, j, k] == array[i - 1, j, k]) i--;
        }
        return array;
    }
    else return array = new int[1,1,1];
}



Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of floors: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

//int[,,] myArray = CreateRandom3dArray(m, n, p, min, max);
int[,,] myArray = Unic(m, n, p, min, max);
Show3dArrayWithIndexes(myArray);
*/





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int sum = 1;
    int a = 0; //шаг
    for (int i = 0 + a, int j = 0; j < (columns - a); j++)
    {
        array[i, j] += sum;
        sum++;

        for (j = 0; j < columns - 1; j++)
        {

            array[i, j] += sum;
            sum++;
        }
    }


    return array;
}




Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSpiralArray(m, n);
Show2dArray(myArray);


