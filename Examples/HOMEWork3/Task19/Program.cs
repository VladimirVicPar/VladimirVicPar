// ## Задача 19  Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

//  14212 -> нет
//  12821 -> да
//  23432 -> да

// Решение задачи

Console.WriteLine("Введите пятизначное число, ");
int n = Convert.ToInt32(Console.ReadLine());

int x, y, c, d;
if (n > 9000 && n < 10000)
{
    x = n / 1000; y = n % 10; c = (n / 1000) % 10; d = (n / 10) % 10;
    if (x == y && c == d)
    {
        Console.WriteLine("Это число - палиндром!");
}
else Console.WriteLine("Введенное число - не палиндром.");
}



//int y1 = 0;
//int y2 = 0;
//int y4 = 0;
//int y5 = 0;

//if (x <= 99999 && x >= 10000)
//{
//    if (y5 == y1 && y4 == y2)
//    {
//        y1 = x % 10;              // пятая цифра
//        y2 = x % 100 / 10;        // четвертая цифра
//        y4 = x % 10000 / 1000;    // вторая цифра
//        y5 = x % 1000000 / 10000; //  первая цифра
//        Console.WriteLine("Это палиндром!");
//    }
//    else
//        Console.WriteLine("Это... Не палиндром");
//}
//else if (x < 10000)
//    Console.WriteLine("Некорректное число.");
//else if (x > 99999)
//    Console.WriteLine("Некорректное число.");

//
//Console.WriteLine("Введите число: ");
//string number = Console.ReadLine();
//int len = number.Length;
//
//if (len == 5)
//{
//    if (number[0] == number[4] && number[1] == number[3])
//    {
//        Console.WriteLine($"{number} - Палиндром");
//    }
//    else
//    {
//        Console.WriteLine($"{number} - НЕ палиндром");
//    }
//}
//else
//{
//    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// 




// void SearchArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        if(int)
//    }
// }



// 
//Console.WriteLine("Введите число: ");
//string number = Console.ReadLine();
//int len = number.Length;

//if (len == 5)
//{
//    if (number[0] == number[4] && number[1] == number[3])
//    {
//        Console.WriteLine($"{number} - Палиндром");
//    }
//    else
//    {
//        Console.WriteLine($"{number} - НЕ палиндром");
//    }
//}
//else
//{
//    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
//}

