// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int ReadData(string line) // получаем данные 
 {
// выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
 }
// универсальный метод генерации и заполнения массива
int[] fillArray (int num, int downBorder, int topBorder)
 {
    //генератор случайных чисел
    Random numSintezator = new Random();
    // создаем массив 
    int[] arr = new int[num];
    // тест границ
     if(downBorder < topBorder)
     {
        // заполняем массив
         for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder +1);
        }
    }
    // возвращаем результат
     return arr;
 }
// печатает одномерный массив
void Print1DArr(int[] arr)
 {
     for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
     Console.WriteLine(arr[arr.Length - 1]);
 }
// М который вычислял положительные и отрицательные числа.
int[] NegotivPozitivSums(int[] arr)
 {
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
      if( arr[i]>0)
    {
       sums [0]+= arr[i];
    }
    else 
     {
    sums [1]+= arr[i];
     }
    }
     return sums;
 }

//вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// тело программы
int arrayLengt = ReadData ("введите длинну массива: ");
int downBorder= ReadData ("введите нижнюю границу: ");
int topBorder= ReadData ("введите верхнюю границу: ");
int[] inputArray = fillArray (arrayLengt, downBorder,topBorder);
Print1DArr (inputArray);
int[] sumArray = NegotivPozitivSums (inputArray); 
PrintResult ("Сумма > 0: " + sumArray [0] + "Сумма < 0: "+ sumArray [0]);
Print1DArr(sumArray);