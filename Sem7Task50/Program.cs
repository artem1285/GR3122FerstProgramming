// Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или 
//же указание, что такого элемента нет.
// Ввод данных пользователем
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число, переводим из строки в число
     int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
     return number;
}

//Универсальный метод генерации и заполнения двумерного массива, возвращает одномерный массив
int[,] Fill2DArray(int countRow, int countColumn, int downBorder, int topBorder)
{
     System.Random rand = new System.Random(); // случайное заполнение числами 
     int[,] array2D = new int[countRow, countColumn]; // сам массив, строки, столбцы
    for (int i = 0; i < countRow; i++) // тут проходим строки
     {
         for (int j = 0; j < countColumn; j++) // тут проходим столбцы
         {
             array2D[i,j] = rand.Next(topBorder, downBorder + 1); // так же выдаем случайное число 
         }
     }
     return array2D;
}
// М который печатает массив
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
}
// метод нахождения элемента
int Find2DElement(int countRow, int countColumn, int[,] array2D)
{
        if (countRow < array2D.GetLength(0) && countColumn < array2D.GetLength(1))
     {
        return array2D [countRow, countColumn];
     }
    else
     {
     return -1;
     }
}
// вывод на экран результата
void Print(string line)
{
     Console.WriteLine(line); 
}

// программа
int row = ReadData("Введите количество строк ");
int column = ReadData("Введите количество столбцов ");
int downBorder = ReadData("Введите нижнюю границу массива ");
int topBorder = ReadData("Введите верхнюю границу массива ");

int [,] arr2D = Fill2DArray(row,column,downBorder,topBorder); // создаем сам массив
Print2DArray(arr2D); // печать массива

int x = ReadData("Введите номер строки ");
int y = ReadData("Введите номер столбца ");

Print((Find2DElement(x,y,arr2D) == -1) ? "такого элемента нет" : ("Элемент: " + Find2DElement(x,y,arr2D)));
