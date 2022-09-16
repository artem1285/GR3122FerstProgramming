// Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
     return number;
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
     Console.Write("[" + arr[0] + ", "); // "["формирует массив и оформляет его в квадратные скобки
     for (int i = 1; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.Write(arr[arr.Length - 1] + "]");
     Console.WriteLine();
}
// изменяем массив
int[] ChangeArr(int[] arr)
{
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] *= -1;
     }
     return arr;
}
int arrLength = ReadData("Введите длинну массива: ");
int start = ReadData("Введите минимальное значение: ");
int stop = ReadData("Введите максимальное значение: ");
int[] arr =  GenArray(arrLength, start, stop);
PrintArray(arr);
PrintArray(ChangeArr(arr));
