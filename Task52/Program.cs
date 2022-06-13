/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/ 

void FillArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}
string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + "; " ;
    }
    return result;
}
int m = 3;
int n = 4;
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {ArithmeticMean(array)}  " );
