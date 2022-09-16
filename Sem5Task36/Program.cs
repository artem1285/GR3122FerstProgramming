// Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Универсальный метод генерации и заполнения массива из 31 задачи
int[] FillArray (int arrLength, int start, int stop)
 {
    int[] array = new int[arrLength]; // генератор случайных чисел
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++) // проходим по всему массиву
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
 }
// печать массива
void Print1DArray(int[] arr)
 {
     Console.Write("[" + arr[0] + ", ");
     for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
     Console.WriteLine(arr[arr.Length - 1] + "]");
     //Console.WriteLine();
 }
// считаем сумму элементов
int EvenSumPozition (int[] arr)
 {
    int sum  = 0;
    for (int i = 1; i < arr.Length; i=i+2)// проходим только четные позиции
    {
        sum += arr[i]; 
    }
   return sum;
 }
// вывод в консоль
void PrintData(string line)
 {
    Console.WriteLine(line);
 }



//программа
int[] array = FillArray (10,-20,100);
Print1DArray (array); // печатает массив
int sumArray = EvenSumPozition (array); 
PrintData ("Сумма нечетных элементов: " + sumArray);