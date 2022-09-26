// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Вывод на экран
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Генерация случайного двумерного массива.
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
    int[,] arr = new int[countRow, countColumn];
    Random rnd = new Random();
    for (int i = 0; i < countRow; i++)
    {
         for (int j = 0; j < countColumn; j++)
         {
         arr[i, j] = rnd.Next(downBorder, topBorder);
         }
    }
    return arr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i, j]}\t");
         }
         Console.WriteLine();
     }
}

// среднее араифметическое по столбцам
double[] Count(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             arr[j] = arr[j] + matr[i, j];
         }
    }

     AverageArithmetic(arr, matr.GetLength(0));
     return arr;
}

// прохождение по всем элеметам массива
double[] AverageArithmetic(double[] arr, int numbers)
{
     for (int k = 0; k < arr.Length; k++)
     {
         arr[k] = Math.Round(arr[k] / numbers, 2);
     }
     return arr;
}

// Печать одномерного массива
void PrintArray(double[] arr)
{
     for (int i = 0; i < arr.Length; i++)
     {
         Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

int inputLen = ReadData("Введите число строк массива: ");
int inputCol = ReadData("Введите число столбцов массива : ");
int Start = ReadData("Введите минимальное значение элемента массива: ");
int Stop = ReadData("Введите максимальное значение элемента массива: ");

int[,] matrix =  Fill2DArray(inputLen, inputCol, Start, Stop);

PrintResult("Исходный массив: ");
Print2DArray(matrix);

Console.WriteLine("Среднее арифметическое:");
