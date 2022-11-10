// ## Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//int number = ReaderWriterLock Int ("Введите число" );
//int count = number.ToString().Length;
//Console.Write(MakeArray(number, count));

Console.WriteLine("Введите трехзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

while (99 <= x || x >= 99999)
{
    if(x > 99 || x <= 999)
    {
        x = x / 100;
        Console.WriteLine(x);
    }
    if(x > 9999 || x <= 99999) x = x / 100;
    {
        Console.WriteLine(x % 10);
    }
    if(x <= 99)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        Console.WriteLine("число не подходит, попробуйте другое");
    }
}