// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Exponentiate(int number1, int number2)
{
    int expo = 1;
    if (number2 >= 0)
    {
        for (int count = 1; count <= number2; count++)
            expo *= number1;
            return expo;
    }
    else
        return 0;
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} to the power {b} is equal to {Exponentiate(a, b)}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// А что делать если число отрицательное? Выводим -1 или сумму цифр со знаком минус? -35 -> -1 или -35 -> -8 

/*
int SumOfDigit(int number)
{
    int sum = 0;
    if (number >= 0)
    {
        while (number != 0)
        {
            sum = sum + number % 10;
            number /= 10;
        }
        return sum;
    }
    else
        return -1;
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of digits in number {a} is {SumOfDigit(a)}");
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
int[] ManMadeArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Input array element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Array is: [ ");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write("] \n");
}

Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = ManMadeArray(n);
ShowArray(myArray);
*/










