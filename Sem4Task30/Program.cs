// Напишите прорамму, которая выводит массив из 8 элементов, 
//заполненую 0 –ями единиц в случайном порядке.
// Вариант Анатолия
int ReadData(string line) // получаем данные 
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
int [] GenArr (int num)
{
   Random  ren  = new Random (); // создал рандом
   int [] arr = new int [num]; // создал массив
   for (int i = 0; i < arr.Length; i++) // заполнил цикл
{
arr [i] = ren.Next (0,2);
}
return arr; // выдал
}
void PrintArr (int [] arr)
{
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write ( arr [i] + ",");
}
Console.WriteLine ( arr [arr.Length - 1]);
}
int arrLen = ReadData ("Введите длинну массива: ");// сначала получаем число, длинну массива, которую мы хотим сдел
int [] array = GenArr(arrLen);// создаем массив, вызываем метод генерации. Передачи число которое получили от пользователя. 
PrintArr (array); //передаем массив, который сгенерировали 
// можно и так PrintArr(GenArr(ReadData("Введите длинну массива: ")));