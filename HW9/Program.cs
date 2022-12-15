// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNaturalNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNaturalNumbers(number - 1); 
}

Console.Write("Input a natural number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
// Решено с помощью рекурсии
int SumBetweenNumsRec(int m, int n)
{
    if (m > n)
        return SumBetweenNumsRec(m - 1, n) + m;
    else if (m < n)
        return SumBetweenNumsRec(m, n - 1) + n;
    else return n;
}

// Решено просто математически
int SumBetweenNums(int m, int n)
{
    if (m > n)
        return (m + n) * (m - n + 1) / 2;
    else if (m < n)
        return (m + n) * (m - n - 1) / -2;
    else return n;
}

Console.Write("Input the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the elements between {m} and {n} is {SumBetweenNumsRec(m, n)}");
Console.WriteLine($"The sum of the elements between {m} and {n} is {SumBetweenNums(m, n)}");
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
int Ackermann( int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return Ackermann(m - 1, 1);
    else if ((m > 0) && (n > 0))
        return Ackermann(m - 1, Ackermann(m, n - 1));
    else
        return n + 1;
}

Console.Write("Input the first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
*/