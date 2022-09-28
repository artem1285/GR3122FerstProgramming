// Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если 
//это невозможно, программа должна вывести сообщение для пользователя.

// вариант евгения
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
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
//Заполняем массив случайными числами
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

//  Меняем строки со столбцами
int[,] Rotate2DArray(int[,] matr)
{
    int[,] matrix = new int[matr.GetLength(1), matr.GetLength(0)]; // создает новую матрицу, проходит
    //старую матрицу matr, которую ввел в метод, а запонляет новаую матрицу, новыми значениями 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matrix[j, i] = matr[i, j]; // считывает в обратном порятке
        }
    }
    return matrix;
}
 // Метор препода

 //  Меняем строки со столбцами
int[,] Rotate2DArraySwap(int[,] matr)
{
    int buf = 0; // это буферный элемент 
    for (int i = 0; i < matr.GetLength(0); i++) // проход останется
    {
        for (int j = i + 1; j < matr.GetLength(1); j++) //= i + 1 - каждую строку с диагонали +1
        {
            buf = matr[j, i]; // в этот buf ложим тот элемент который хотим поменять 
            matr[j, i] = matr[i, j]; // в столбец ставим элемент со строки
            matr[i, j] = buf; // элемент со строки возвращаем элемент, который положили в буфер из столбца
        }
    }
    return matr; // выдаст ту же матрицу 
}

// метод который проверяет что матрица квадратная - транспонирование
bool TestRot(int[,] matr) // на входе матрица int[,] matr
{
    if (matr.GetLength(0) == matr.GetLength(0))  // если размерности матрицы равны
    {
        return true; // тогда возвращаем true
    }
    else
    {
        return false;
    }
}
// программа
int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

// по М препода
if (TestRot(matrix)) // если тест TestRot проходит и передадим маирицу которую создали 
{
     DateTime d1 = DateTime.Now; //проверка скорости считывания, работа алгоритма
    int[,] matrixChanged1 = Rotate2DArray(matrix);
     Console.WriteLine(DateTime.Now-d1);
  //Print2DArray(matrixChanged1);

  int[,] matrixChanged2 = Rotate2DArraySwap(matrix);
    //Print2DArray(matrixChanged2);
 }
else
{
    Console.WriteLine("Матрицу транспонировать нельзя!");
}