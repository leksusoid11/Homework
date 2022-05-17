/*
Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.
456 -> 46
782 -> 72
918 -> 98
*/



int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();

Console.WriteLine();
Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");
Console.WriteLine();