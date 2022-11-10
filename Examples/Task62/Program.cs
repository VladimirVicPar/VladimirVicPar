// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


//Cоздание двумерного массива.
// int[,] createArray(int n, int m)
// {
//    int[,] array = new int[n, m];
//    return array;
//}

// Заполнение массива
// int[,] fillArray(int[,] array, int min, int max)
//{
//    Random rand = new Random();
//    for (int i = 0; i < array.GetLength(0); i++)
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = rand.Next(min, max);
//        }
//    return array;
//}

//Печать массива
// void printArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++, Console.WriteLine(""))
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + "\t");
//        }
// }

//Метод, сортировки пузыркoм двумерного массива.

// void BubblerSort(int[,] array)
// {
//     int x = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//    {
//         for (int j = 0; j < array.GetLength(1); j++)
//        {
//             for (int k = 0; k < array.GetLength(1); k++)
//            {
//                for (int l = 0; l < array.GetLength(1); l++)
//                {
//                    if (array[i, j] <= array[k, l])
//                    {
//                        x = array[i, j];
//                        array[i, j] = array[k, l];
//                        array[k, l] = x;
//                    }
//
//                }
//            }
//
//        }
//    }
// }

//Решение.

//int[,] array = createArray(5, 5);
//array = fillArray(array, 0, 10);
//printArray(array);
//BubblerSort(array);
//Console.WriteLine("");
//printArray(array);

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}