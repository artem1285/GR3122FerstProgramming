//  Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

// 
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Печать двумерного массива. Посмотреть какой будет массив заполен.
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}
//  Меняем первую строку с последней местами
void Change2DArray(int[,] matr)
{
    //int[] arr = new int[matr.GetLength(1)]; 
    int temp = 0; // в массиве лучше не объявлять переменную, а объявить ее с наружи.
    for (int i = 0; i < matr.GetLength(1); i++) // берет цикл от 0 до конца строки 
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}
// сама программа 
int m = ReadData("Введите количество строк M: "); // получаем от пользователя м
int n = ReadData("Введите количество столбцов N: "); // получаем от пользователя N
int[,] matrix = new int[m, n]; // создает матрицу

Fill2DArray(matrix, 1, 9); // заполняет двумерный массив, мин 1, мах 9
Print2DArray(matrix); // потом печататет. 
Change2DArray(matrix); // потом меняет 
Print2DArray(matrix);// потом печататет. 