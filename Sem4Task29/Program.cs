// Напишите проргамму, 
//которая задает массив из 8 элементов и выводит их на экран
int ReadData(string line) // получаем данные 
{
    // выводим сообщение
     Console.WriteLine(line);
    //считываем число
     int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
int [] GenArr (int num, int start, int stop) // две границы массива
{
    Random ren = new Random (); // создал рандом
    int [] outArr = new int [num]; // создал массив
    for (int i = 0; i < outArr.Length - 1; i++) // заполнил цикл
{
outArr [ i ] = ren. Next (start, stop);
}
return outArr; // выдал
}
// печать результата
void PrintArr (int [] outArr)
{
    for (int i = 0; i < outArr.Length; i++)
    {
      Console.Write ( outArr [i] + ",");
    }
  Console.WriteLine ( outArr [outArr.Length - 1]);
}
int arrLen = ReadData ("Введите длинну массива: ");// сначала получаем число, длинну массива, которую мы хотим сделать
int start = ReadData ("Введите границу начала массива: "); // переменная для первого числа
int stop = ReadData ("Введите границу конца массива: ");// переменная для второго числа
int [] array = GenArr(arrLen, start, stop);//  переменная для заполненного массива
PrintArr (array); //передаем массив, который сгенерировали 


// я честно не могу понять правильно или нет я понял эту здачу и ее решение?