﻿// ## Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 1000 | x < 100)
{
    Console.WriteLine("Ошибка! Введите трехзначное число: ");
}
else
{
    x = x / 100;
    x = x % 10;
    Console.WriteLine(x);
}