// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// массив, заполненыцй вещественными числами 
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random(); // заполнение случайными числами
    double[,] array2D = new double[countRow, countColumn]; // сам массив
    for (int i = 0; i < countRow; i++) // тут проходим строки
    {
         for (int j = 0; j < countColumn; j++) // тут проходим столбцы
         {
             array2D[i,j] = rand.Next(topBorder, downBorder)* rand.NextDouble(); // так же выдаем случайное число 
         }
    }
    return array2D;
}
void Print2DArray(double[,] arr) //печать массива
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
         for (int j = 0; j < arr.GetLength(1); j++)
         {
            Console.Write($"{arr[i, j]} ");
         }
         Console.WriteLine();
    } 
}
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
// int topBorder = ReadData("Введите верхнюю границу: ");
// int downBorder = ReadData("Введите нижнюю границу: ");
double[,] arr2D = Fill2DArray(row,column,5,5);
Print2DArray(arr2D);