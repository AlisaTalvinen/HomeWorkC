// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4
/*
int CounterPositiveNumbers(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write("Input a number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Input a number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number of positive numbers is {CounterPositiveNumbers(m)}");
*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void Crosspoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (b1 * k2 - b2 * k1) / (k2 - k1);

    if (b1 == b2 && k1 == k2)
        Console.WriteLine("The lines match");
    else if (b1 != b2 && k1 == k2)
        Console.WriteLine("The lines are parallel");
    else
        Console.WriteLine($"The crosspoint of the lines is x = {x}; y = {y}");
}

Console.Write("Input b1 of y = k1 * x + b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1 of y = k1 * x + b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2 of y = k2 * x + b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2 of y = k2 * x + b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Crosspoint(b1, k1, b2, k2);
*/

