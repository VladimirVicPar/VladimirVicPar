// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.



//int[]array = new int [10];

// Cоздание двумерного массива.
int[,] createArray(int n, int m)
{
    int[,] array = new int[n, m];
    return array;
}

// Заполнение массива
int[,] fillArray(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    return array;
}

// Печать массива
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
}




// Метод замены первой строки с последней в массиве.
void ChangeArray(int[,] array)
{
    int x = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        x = array[0, j];
        array[0, j] = array[array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = x;
    }
}

// Решение.

int[,] array = createArray(5, 5);
array = fillArray(array, 0, 10);
printArray(array);
ChangeArray(array);
Console.WriteLine("");
printArray(array);
