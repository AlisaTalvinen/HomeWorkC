// Для задач 34 и 36 раскомментировать методы CreateRandomArray, ShowArray, их запрос, а также запрос значений (строки 5 - 32).
// В 34 задаче трехзначность задается самим пользователем: 100 - 999, иначе метод (CreateRandomArray) был бы не универсальным.
// Для 38 задачи раскомментировать строки 64 - 109. Не смогла сложить два массива разного вида - int и double, потому пока такое решение. Буду еще думать, искать. 

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
*/

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int EvenNumberCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

Console.WriteLine($"The number of even numbers in the array is {EvenNumberCounter(myArray)}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumOfElementsInOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Console.WriteLine($"Sum of array elements in odd positions is {SumOfElementsInOddPositions(myArray)}");
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateDoubleRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    diff = max - min;
    return diff;
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myDoubleArray = CreateDoubleRandomArray(n, min, max);
ShowDoubleArray(myDoubleArray);

Console.WriteLine($"The difference is {DifferenceMaxMin(myDoubleArray)}");
*/

