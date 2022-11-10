// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.



int[]array = new int [10];

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
