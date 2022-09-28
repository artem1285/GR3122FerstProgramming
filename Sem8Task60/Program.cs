// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.

// заполнение 3х мерного массива
void Fill3DArray(int[,,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                arr[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
}

// печатаем массив
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})\t"); // печать массива, указание индекса
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array3D = new int[4, 5, 9]; // создали размер массива
Fill3DArray(array3D, 0, 9); // min max числа в массиве
Console.WriteLine("Массив: ");
Print3DArray(array3D); // печать массива
