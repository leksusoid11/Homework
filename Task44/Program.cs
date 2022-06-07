/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/ 

Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 40);
System.Console.WriteLine($"Количество чисел Фибоначчи: {N}");

int[] GetFibonacci(int N)
{
    int prev1 = 1;
    int prev2 = 1;
    int[] fib = new int[N];
    fib[0] = 1;
    fib[1] = 1;
    for (int i = 2; i < N; i++)
    {
        fib[i] = prev1 + prev2;
        prev2 = prev1;
        prev1 = fib[i];
    }
    return fib;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

PrintArray(GetFibonacci(N));
System.Console.WriteLine(); 