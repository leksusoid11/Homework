/*
Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int rundomNumber = new Random().Next(100,1000);

Console.Write (rundomNumber);

int number = (rundomNumber % 100) / 10;

Console.Write ($" -> { number} ");
