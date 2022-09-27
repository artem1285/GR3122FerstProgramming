// .Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
// Вывод результата в консоль
void PrintData(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}
//Универсальный метод генерации и заполнении двумерного массива 
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    //структура, которая заполняет массив 
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn]; // сам массив
    // как проходит нумерация
    // по х 0 1 2 3    начинается с 0 и по х и по у
    // по у 0
    //      1
    //      2
    //      3 
    for (int i = 0; i < countRow; i++) // тут проходим строки
    {
         for (int j = 0; j < countColumn; j++) // тут проходим столбцы
         {
             array2D[i,j] = rand.Next(topBorder, downBorder + 1); // так же выдаем случайное число 
         }
    }
    return array2D;
}
// массив цветов
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
// печать двумерного массива цветом
void Print2DArrayColored(int[,] matr) //хотим напечатать цветом
{
     for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
            Console.ForegroundColor = col[new System.Random().Next(0,16)];;
            Console.Write($"{matr[i, j]} ");
            Console.ResetColor(); // сброс цвета до заводских настроек
         }
         Console.WriteLine();
    } 
}
int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int[,] arr2D = Fill2DArray(row,column,10,99);
Print2DArrayColored(arr2D);
