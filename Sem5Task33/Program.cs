﻿// Задайте массив. Напишите программу, 
//которая определяет, присутствует ли заданное число в массиве.
int ReadData(string line)
{
    // Выводим сообщение
     Console.WriteLine(line);
    // Считываем число
     int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
     return number;
}
// Печать результата
void PrintResult(string line)
{
     Console.WriteLine(line);
}
// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
   Random ren = new Random();
   for (int i = 0; i < arrLength; i++)
    {
         array[i] = ren.Next(start, stop + 1);
    }
   return array;
}
// печатаем массив
void PrintArray(int[] arr)
{
     Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
         Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}
// изменяем массив
bool ChekNumInArr(int[] arr, int num) // передает массив и элемент
{
   for (int i = 0; i < arr.Length; i++) // проходит по всему массиву 
     {
        if (arr[i] == num)
      {
        return true;
      }
    }
   return false;
}
int arrLength = ReadData("Введите длинну массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");
int[] arr = GenArray(arrLength, start, stop); // генерирует массив
PrintArray(arr); // печатает массив
int num = ReadData("Введите искомое значение: ");
PrintResult (num + "->  " + ChekNumInArr (arr,num)); // проверяет есть ли этот элемент или нет
