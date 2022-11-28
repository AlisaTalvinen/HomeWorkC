// Урок 2. Массивы и функции в программировании

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int arg)
{
    int result = arg / 10 % 10;
    return result;
}

Console.Write("Input a tree-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecondDigit(number));
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumber(int arg)
{
    if (arg >= 100)
    {
        while (arg > 1000)
        {
            arg = arg / 10;
        }
        int thirdNum = arg % 10;
        return thirdNum;
    }
    else
    {
        return -1;
    }
}

Console.Write("Input an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumber(number);

if(result >= 0)
Console.WriteLine($"Third number of {number} is {result}");
else
Console.WriteLine($"There is no third digit in {number}");
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekend(int num)
{
    if (num == 6 || num == 7)
        return true;
    else
        return false;
}

Console.Write("Input the number of day of the week (1-7): ");
int numDay = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine(Weekend(numDay));

bool day = Weekend(numDay);

if (day == true)
    Console.WriteLine($"The {numDay} day is a weekend");
else
    Console.WriteLine($"The {numDay} day is not a weekend");
*/
