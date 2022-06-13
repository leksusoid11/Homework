/*
Задача 64: Задайте значения M и N. Напишите программу,
 которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/ 

int n = InputNumbers("Введите m: ");
int m = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n,m, count);
Console.Write(1);

void PrintNumber(int n, int m, int count)
{
  if (count > n) return;
  PrintNumber(n,m, count + 1);
  Console.Write(count + ", ");
  
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}