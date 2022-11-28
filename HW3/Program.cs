// Урок 3. Массивы и функции в программировании
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
void Palindrome(int arg)
{
    int result = 0;
    int end = arg;

    while (result < end)
    {
        result = result * 10 + arg % 10;
        arg = arg / 10;
    }

    if (result == end) Console.WriteLine($"Yes. Inputed number {end} is a palindrome.");
    else Console.WriteLine($"No. Inputed number {end} is not a palindrome.");
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);
*/


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = x1 - x2;
    double b = y1 - y2;
    double c = z1 - z2;
    double distance = Math.Sqrt(a*a + b*b + c*c);
    return distance = Math.Round(distance,2);
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance 3D is {Distance(x1, y1, z1, x2, y2, z2)}");
*/


// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int arg)
{
    int count = 1;
    while (count <= arg)
    {
        double cube = Math.Pow(count, 3);
        Console.Write($"{cube} ");
        count ++;
    }
}

Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/
