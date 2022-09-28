// Задайте прямоугольный двумерный массив. Напишите программу, которая будет
//находить строку с наименьшей суммой элементов.
void Fill2DArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// печатаем массив
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// метод поиска минимальной строки
int FindMinRow(int[,] arr)
{
    int outIndexRow = -1; // для вывода строки с минимальным значением
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum = arr[i, j];
            }
            if (min > sum)
            {
                min = sum;
                outIndexRow = i + 1;
            }
        }
        sum = 0;
    }
    return outIndexRow;
}

// программа
int[,] array2D = new int[4, 5]; // создали размер массива
Fill2DArray(array2D, 0, 9); // min max числа в массиве
Console.WriteLine("Массив: ");
Print2DArray(array2D); // печать массива

//строка с наименьшей суммой элементов
Console.WriteLine("Минимальная строка в массиве: " + FindMinRow(array2D).ToString());
