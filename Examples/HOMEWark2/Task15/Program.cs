// ## Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

// ФУНКЦИИ--------------------------------------------------------
int ReadInt(string message)
{
    Concole.WriteLine("Введите порядковый номер дня недели, ");
    int a = Convert.ToInt32(Console.ReadLine());
}
// Функция принимает число от 1 до 7 и выводит сообщение - выходной день или нет.
// *** Костыль, но я тренировал функции. проблема с return была. ***
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 | a == 6)
        {
            Console.Write("Под цифрой" + a + "-Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + "-Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не соответствующее дню недели");
    }
    return;
}

// 

namespace ConsoleApp3 
{ 
    internal class Program 
    { 
        static void Main(string[] args) 
        { 
            Console.Write(" Нужно узнать, является ли этот день выходным или нет?  "); 
            while (true) 
            { 
                Console.Write("\n Введите номер дня недели  "); 
                int num = int.Parse(Console.ReadLine()); 
                if (num >= 1 && num <= 5) 
                { 
                    Console.Write(" Нет, это не выходной"); 
                } 
 
                else if (num >= 6 && num <= 7) 
                { 
                    Console.Write(" Да, это выходной"); 
                } 
                else Console.Write(" Не существует такого дня недели"); 
            } 
        } 
    } 
}