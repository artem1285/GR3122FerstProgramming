// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//массив заполненный случайными положительными трёхзначными числами
int[] FillArray(int arrLength, int start, int stop)
{
    Random rand = new Random(); //Генератор случайных чисел
    int[] array = new int[arrLength]; //Создаем массив
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(start, stop + 1); //Заполняем массив.Расчет.
    }
    return array; //Возвращаем результат (массив)
}

// подсчет четных чисел
int EvenCount(int[] array)
{
    int sum = 0; // переменная в которой будем накапливать
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum++;
    }
    return sum;
}

//Вывод массива
void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array)); //Вывод массива через запятую
}

// Вывод ответа
void PrintResult(int answer)
{
    Console.WriteLine("Количество четных элементов -> {0}", answer); //Вывод результата
}
int[] array = FillArray(5, 100, 999); //Вводим исходные значения для массива
Print1DArray(array); //Печать массива
PrintResult(EvenCount(array)); //Печать результата
