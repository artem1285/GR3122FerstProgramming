// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// вариант евгения
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
// считаем числа в массиве
int CountElem (int[] arr)
{
     int sum = 0; // берет сумму 
     for (int i = 0; i < arr.Length; i++)
     {
     if (arr[i] >= 10 && arr[i] <= 99)
     {
            sum++;
     }
     }
     return sum;
}
int[] arr = GenArray(123, 1, 1000); // генерация массива
PrintArray(arr); // выводит массив который создал
PrintResult("В массиве " + CountElem(arr) + " элементов в отрезке [10,99]"); // вывод результата
// метод подсчета CountElem(arr) сразу вставляет в результат
// есть еще метод михаила