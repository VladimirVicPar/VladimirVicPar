﻿// // НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
// ## Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int res = x;
if (x < 100 | x > 999)
{
    Console.WriteLine("Ошибка! Введите трехзначное число: ");
}
else
{
    res = x / 100;
    res = x % 10;
    Console.WriteLine(res);
}