
Console.WriteLine("Введите число, ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
Console.WriteLine(max);
