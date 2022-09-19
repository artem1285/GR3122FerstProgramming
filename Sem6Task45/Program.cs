// Напишите программу, 
//которая будет создавать копию заданного одномерного массива 
//с помощью поэлементного копирования.

//вариант максим
// сама программа, Компилятор считывает только ее, а потом уже залазиет в методы
int length = ReadData("Задайте длину массива: "); // length как глобальная переменная 
int[] array = CreateRandomArray(length);
Print1DArray(array);
PrintResult("Копия массива");
Print1DArray(MakeArrayCopy(array));
PrintResult("Копия массива Clone");
Print1DArray((int[])array.Clone());

// Получение данных от пользователя и преобразование в число
int ReadData(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine()??"0");
  return number;
}

// Вывод результата в консоль
void PrintResult(string data)
{
    Console.WriteLine(data);
}

// Создание и заполнение массива числами
int[] CreateRandomArray(int leng)
{
    int[] array = new int[leng];
    Random rnd = new Random();

    for (int i = 0; i < leng; i++)
    {
        array[i] = rnd.Next(-1000, 1000);
    }
    return array;
}

// Вывод массива в консоль
void Print1DArray(int[] arr)
{
    Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
}

int[] MakeArrayCopy(int[] arr)
{
  int[] rev = new int[arr.Length];
  for(int i = 0; i < arr.Length; i++)
  {
    rev[i] = arr[i];
  }
  return rev;
}